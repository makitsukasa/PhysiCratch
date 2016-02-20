using UnityEngine;
using System.Collections;

public class Cratch : MonoBehaviour
{

	public /*const*/ GameObject Sprite_GameObject;
	private const int SpriteNum = 20;

	void Start()
	{
		for( var x = -( SpriteNum / 2 ); x <= ( SpriteNum / 2 ); x++ )
		{
			for( var y = -( SpriteNum / 2 ); y <= ( SpriteNum / 2 ); y++ )
			{
				Vector3 pos = new Vector3( x * ( (float)1 / SpriteNum ), y * ( (float)1 / SpriteNum ) );
				Quaternion rota = Quaternion.identity;
				GameObject piyo = Instantiate( Sprite_GameObject, pos, rota ) as GameObject;
				piyo.transform.SetParent( this.transform );
				if( x == -( SpriteNum / 2 ) || x == ( SpriteNum / 2 ) ||
					y == -( SpriteNum / 2 ) || y == ( SpriteNum / 2 ) )
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
