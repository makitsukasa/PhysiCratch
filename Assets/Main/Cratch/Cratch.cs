using UnityEngine;
using System.Collections;

public class Cratch : MonoBehaviour
{

	public /*const*/ GameObject Sprite_GameObject;
	public const int Side_PieceNum = 30;
    public const int PieceNum = Side_PieceNum * Side_PieceNum;
	public const float PieceSize = 0.3125f / Side_PieceNum;

	void Start()
	{

		for( var x = 0; x < Side_PieceNum; x++ )
		{
			for( var y = 0; y < Side_PieceNum; y++ )
			{
				Quaternion rota = this.transform.rotation;
				Vector3 pos = new Vector3( x * ( (float)1 / Side_PieceNum ), y * ( (float)1 / Side_PieceNum ) );
				pos += new Vector3( 0.5f / Side_PieceNum - 0.5f, 0.5f / Side_PieceNum - 0.5f );
				pos = rota * pos; //Quaternion * Vector3 : Rotation of the vector
                pos += this.transform.position;
				GameObject piyo = Instantiate( Sprite_GameObject, pos, rota ) as GameObject;
				piyo.transform.localScale = new Vector3( PieceSize, PieceSize );
				piyo.transform.SetParent( this.transform );
				//border : collider ON
				if( x == 0 || x == ( Side_PieceNum - 1 ) ||
					y == 0 || y == ( Side_PieceNum - 1 ) )
				{
					piyo.GetComponent<CratchPiece>().SwitchCollider( true );
				}
			}

		}
	}
	
	void Update()
	{
		/*Debug.Log( ( this.transform.rotation.x * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.y * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.z * Mathf.PI ).ToString() + "," +
			( this.transform.rotation.w * Mathf.PI ).ToString() );*/
		if( this.transform.position.y < -10 ) Destroy( this.gameObject );
	}
}
