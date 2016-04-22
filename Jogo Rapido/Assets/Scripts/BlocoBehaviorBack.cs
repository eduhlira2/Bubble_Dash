using UnityEngine;
using System.Collections;

public class BlocoBehaviorBack : MonoBehaviour {

	public float speed;
	public float y;
	public GameObject Player;
	private bool pontuado;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Alien")as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

		y = transform.position.y;
		y += speed * Time.deltaTime;
		transform.position = new Vector3 (transform.position.x, y, transform.position.z);

		if (y <= -16.2f) {
			Destroy(transform.gameObject);
		}

		// if (transform.position.y < Player.transform.position.y && pontuado == false) {
		// pontuado = true;

		// PlatformerCharacter2D.pontuacao++;


	
	}
}
