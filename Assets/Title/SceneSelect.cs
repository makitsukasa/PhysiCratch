using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneSelect : MonoBehaviour
{

	public GameObject StageNameButton;
	public GameObject ScrollContent;

	void Start()
	{
		foreach( var scene in EditorBuildSettings.scenes )
		{
			string sceneName = 
				scene.path.Replace( "Assets/Scene/", "" ).Replace(".unity","");
			if( sceneName == "Title" || 
				sceneName == "Clear" || 
				sceneName == "HowToPlay" ) continue;

			GameObject hoge = Instantiate(StageNameButton);
			hoge.transform.parent = ScrollContent.transform;
			hoge.GetComponent<StageSelectButton>().SetStr( sceneName );

		}
	}

}
