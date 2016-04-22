using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {
	public GameObject PauseMenu;
	public string GameControllerTag;

	void OnMouseDown()
	{
		if (gameObject.name.Equals ("bnt-pause")) {
			GameObject.FindGameObjectWithTag("pause").GetComponent<SpriteRenderer>().enabled = false;
			PauseMenu.SetActive(true);
			GameObject.FindGameObjectWithTag(GameControllerTag).GetComponent<PauseGame>().SetPause(true);

		}

		if (gameObject.name.Equals ("bnt-play")) {
			GameObject.FindGameObjectWithTag("pause").GetComponent<SpriteRenderer>().enabled = true;

			PauseMenu.SetActive(false);
			GameObject.FindGameObjectWithTag(GameControllerTag).GetComponent<PauseGame>().SetPause(false);
		}


	}

	void Stop()
	{
		Time.timeScale = 0;
	}

}
