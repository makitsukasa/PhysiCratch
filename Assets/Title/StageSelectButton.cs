using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelectButton : MonoBehaviour {

	private string sceneName;

	void Start()
	{
		this.gameObject.transform.localScale = new Vector3( 1, 1, 1 );
	}
	
	public void SetStr(string str)
	{
		sceneName = str;
		this.transform.Find( "Button" ).Find( "Text" )
			.GetComponent<Text>().text = str;
	}

	public void OnClickButton()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene( sceneName );
	}

}
