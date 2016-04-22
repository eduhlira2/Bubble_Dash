using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {


	void OnMouseDown()
	{
		Time.timeScale = 1;

		if (gameObject.name.Equals ("Menu")) {

		
			Application.LoadLevel ("Menu");

		}

		if (gameObject.name.Equals ("CharacterSelection")) {


			Application.LoadLevel ("CharacterSelection");
		}

		if (gameObject.name.Equals ("Botões Vikings Falls conf")) {


			Application.LoadLevel ("Eggs_Hall");

		}
		if (gameObject.name.Equals ("bnt-resume")) {


			Application.LoadLevel (Application.loadedLevel);

		}
		if (gameObject.name.Equals ("bnt-mapa")) {

			Application.LoadLevel ("Menu");

		}

		if (gameObject.name.Equals ("bnt-resume-Mapa")) {
			
			Application.LoadLevel ("Menu");

		}


	}
}
