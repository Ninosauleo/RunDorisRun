using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGameManager : MonoBehaviour {

	public Button yourButton;

	public void ClickTest ()
	{
		Debug.Log ("Yes, am here");
	}

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(RestartLevel);
	}

	public void RestartLevel ()
	{
		Debug.Log ("Yes, am here");
		// Reload the level that is currently loaded.
		SceneManager.LoadScene(0);
	}
}
