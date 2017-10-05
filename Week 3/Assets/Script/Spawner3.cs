using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject go;
	public float StartAfter = 1f;
	public float SpawnFrequency = .5f;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {
		transform.position = new Vector3 (-3,5,0);
	
		Instantiate (go, transform.position, Quaternion.identity);


	}
}
