using UnityEngine;
using System.Collections;

public class Cratch : MonoBehaviour
{

	public /*const*/ GameObject Sprite_GameObject;
	public const int PieceNum = 20;

	void Start()
	{

		for( var x = -( PieceNum / 2 ); x <= ( PieceNum / 2 ); x++ )
		{
			for( var y = -( PieceNum / 2 ); y <= ( PieceNum / 2 ); y++ )
			{
				Quaternion rota = this.transform.rotation;
				Vector3 pos = new Vector3( x * ( (float)1 / PieceNum ), y * ( (float)1 / PieceNum ) );
				pos = rota * pos;
                pos += this.transform.position;
				GameObject piyo = Instantiate( Sprite_GameObject, pos, rota ) as GameObject;
				piyo.transform.SetParent( this.transform );
				//border : collider ON
				if( x == -( PieceNum / 2 ) || x == ( PieceNum / 2 ) ||
					y == -( PieceNum / 2 ) || y == ( PieceNum / 2 ) )
				{
					piyo.GetComponent<CratchPiece>().SwitchCollider( true );
				}
			}

		}
	}
	
	void Update()
	{
		Debug.Log( ( this.transform.rotation.x * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.y * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.z * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.w * Mathf.PI ).ToString() );
		if( this.transform.position.y < -10 ) Destroy( this.gameObject );
	}
}
