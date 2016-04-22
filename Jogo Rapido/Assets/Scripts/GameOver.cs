using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public UnityEngine.UI.Text recorde;
	// Use this for initialization
	void Start () {
	
		recorde.text = PlayerPrefs.GetInt ("recorde").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
