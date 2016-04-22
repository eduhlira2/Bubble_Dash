using UnityEngine;
using System.Collections;

public class PlayBotton : MonoBehaviour {



	void OnMouseDown()
	{
		Time.timeScale = 1;

		if (gameObject.name.Equals ("Play")) {


			Application.LoadLevel ("2D");

		}

		if (gameObject.name.Equals ("Alien")) {


			Application.LoadLevel ("2D");
		}

		if (gameObject.name.Equals ("Aliene")) {


			Application.LoadLevel ("1D");

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
