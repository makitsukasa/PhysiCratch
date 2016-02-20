using UnityEngine;
using System.Collections;
using BoxyLib;

public class CratchPiece : MonoBehaviour {

	public /*const*/ GameObject BoxCollider_GameObject;
	private const float TouchRadius = 0.02f;

	void Start () {
		
	}

	private void OnTouch()
	{
		//Instantiate( Effect_CratchPieceDestroy, this.transform.position, Quaternion.identity );
		Destroy( this.gameObject );
		CratchPiece[] cratchPieces = this.transform.parent.GetComponentsInChildren<CratchPiece>();
		foreach( CratchPiece piece in cratchPieces )
		{
			if( ( piece.transform.position - this.transform.position ).magnitude < 0.05 )
			{
				piece.SwitchCollider( true );
				Debug.Log( "true" + piece.transform.position );
			}
		}
	}

	// no collider -> instantiate / yes collider -> destroy
	public void SwitchCollider()
	{
		//  transform.FindChild
		if( transform.Find( "BoxCollider2D" ) == null )
		{
			SwitchCollider( true );
		}
		else
		{
			SwitchCollider( false );
		}
	}

	public void SwitchCollider( bool flag )
	{
		if( flag && transform.Find( "BoxCollider2D" ) == null )
		{
			//create
			GameObject hoge = Instantiate( BoxCollider_GameObject, 
				this.transform.position, Quaternion.identity ) as GameObject;
			hoge.transform.SetParent( this.transform );
		}
		else if( !flag && transform.Find( "BoxCollider2D" ) != null )
		{
			//destroy
			Destroy( transform.Find( "BoxCollider2D" ).gameObject );
		}
		else
		{
			//error
			Vector3 Pos = transform.parent.position;
			Debug.Log( Pos.ToString() + " is already " + flag );
		}
	}
	
	void Update () {

		Vector3 touchPos = TouchUtil.GetTouchWorldPosition();
		touchPos.z = 0;
		float magnitude = ( touchPos - this.transform.position ).magnitude;
		if( TouchUtil.GetTouch_Bool() && magnitude < TouchRadius )
		{
			OnTouch();
		}
	}
}
