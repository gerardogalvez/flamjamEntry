using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public void loadScene(string sceneToLoad)
	{
		Application.LoadLevel (sceneToLoad);
	}

	public void url()
	{
		Application.OpenURL ("http://firefoxmccloud.newgrounds.com/");
	}
}
