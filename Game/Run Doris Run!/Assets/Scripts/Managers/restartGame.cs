using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
	

	public void RestartLevel ()
	{
		// Reload the level that is currently loaded.
		SceneManager.LoadScene (0);
	}
}
