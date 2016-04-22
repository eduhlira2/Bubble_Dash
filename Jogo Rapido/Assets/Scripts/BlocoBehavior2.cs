using UnityEngine;
using System.Collections;

public class BlocoBehavior2 : MonoBehaviour {

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
			Destroy (transform.gameObject);
		}

		if (transform.position.y < Player.transform.position.y && pontuado == false) {
			pontuado = true;

			PlatformerCharacter2D.pontuacao++;
		}
		if (PlatformerCharacter2D.pontuacao >= 50) {
			SpawnObjectEnemy .rateSpawn = 0.6f;
			speed = -28f;
		}else if (PlatformerCharacter2D.pontuacao >= 20) {
			SpawnObjectEnemy .rateSpawn = 0.5f;
			speed = -26f;
	    }else if (PlatformerCharacter2D.pontuacao >= 15) {
			SpawnObjectEnemy .rateSpawn = 0.6f;
			speed = -19f;

		}else if(PlatformerCharacter2D.pontuacao >= 10){
			speed = -16f;
			SpawnObjectEnemy .rateSpawn = 0.7f;

		}else if(PlatformerCharacter2D.pontuacao >= 5){
			SpawnObjectEnemy .rateSpawn = 0.8f;
			speed = -14f;
		}
	
	}
}
