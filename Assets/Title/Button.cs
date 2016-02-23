using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	private string sceneName;
	
	public void SetStr(string str)
	{
		sceneName = str;
		this.transform.Find( "Text" ).GetComponent<Text>().text = str;
	}

	public void OnClickButton()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene( sceneName );
	}

}
