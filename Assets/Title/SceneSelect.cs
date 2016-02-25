using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{

	public GameObject StageNameButton;
	public GameObject ScrollContent;
	public string[] SceneNames;

	void Start()
	{
		foreach( var sceneName in SceneNames )
		{
			/*string sceneName = 
				scene.path.Replace( "Assets/Scene/", "" ).Replace(".unity","");
			if( sceneName == "Title" || 
				sceneName == "Clear" || 
				sceneName == "HowToPlay" ) continue;*/

			GameObject hoge = Instantiate(StageNameButton);
			hoge.transform.parent = ScrollContent.transform;
			hoge.GetComponent<StageSelectButton>().SetStr( sceneName );

		}
	}

}
