using UnityEngine;
using System.Collections;

public class GoHowToPlay : MonoBehaviour {

	public void OnClickButton()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene( "HowToPlay" );
	}

}
