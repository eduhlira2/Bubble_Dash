using UnityEngine;
using System.Collections;

public class CloseExit : MonoBehaviour {
	public GameObject ExitSplash;
	public GameObject[] CollidersToActivate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void CloseIt(){
		for(int i=0;i<CollidersToActivate.Length;i++){
			CollidersToActivate[i].GetComponent<Collider2D>().enabled=true;
		}
		ExitSplash.SetActive(false);
	}
}
