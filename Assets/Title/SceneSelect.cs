using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneSelect : MonoBehaviour {

	public InputField InputField;

	public void OnClickButton()
	{
		Application.LoadLevel( InputField.text );
	}

	public void EditEnd( string str )
	{
		Application.LoadLevel( str );
	}

}
