using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour {

	public void LoadMain ()
	{
		// Reload the level that is currently loaded.
		SceneManager.LoadScene ("Game Options");

}
}