using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGameManager : MonoBehaviour {


	public void RestartLevel ()
	{
		// Reload the level that is currently loaded.
		Application.LoadLevel(Application.loadedLevelName);
	}
}
