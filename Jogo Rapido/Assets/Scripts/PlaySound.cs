using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {
	public AudioClip SoundFX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		AudioSource.PlayClipAtPoint (SoundFX, Camera.main.transform.position);
	}
}
