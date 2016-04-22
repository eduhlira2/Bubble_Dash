using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObjectEnemy : MonoBehaviour {

	public GameObject barreiraPrefab;
	public  static float rateSpawn;
	public float currentTime;
	private int posicao;
	public float posedquerdo;
	public float posdireito;
	private float x;
	public float Rotation;


	// Use this for initialization
	void Start () {

		currentTime = 0;
		rateSpawn = 1f;
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;
		if (currentTime >= rateSpawn) {
			currentTime = 0;
			posicao = Random.Range (1, 6);
			if (posicao > 3) {
				x = posedquerdo;
				GameObject tempPrefab = Instantiate (barreiraPrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (x, tempPrefab.transform.position.y, tempPrefab.transform.position.z);
				tempPrefab .transform.rotation = Quaternion.AngleAxis (Rotation, Vector3.up);
			} else {
				x = posdireito;
				GameObject tempPrefab = Instantiate (barreiraPrefab) as GameObject;
				tempPrefab.transform.position = new Vector3 (x, tempPrefab.transform.position.y, tempPrefab.transform.position.z);
			}
			//GameObject tempPrefab = Instantiate(barreiraPrefab) as GameObject;
			//tempPrefab.transform.position  = new Vector3 (x,tempPrefab.transform.position.y,tempPrefab.transform.position.z);
		}
	}

}
