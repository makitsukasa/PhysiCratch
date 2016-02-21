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
				Vector3 pos = new Vector3( x * ( (float)1 / PieceNum ), y * ( (float)1 / PieceNum ) );
				pos += this.transform.position;
				Quaternion rota = Quaternion.identity;
				GameObject piyo = Instantiate( Sprite_GameObject, pos, rota ) as GameObject;
				piyo.transform.SetParent( this.transform );
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

	}
}
