using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	//Let's you change the axis it rotates (x,y,z) in real time.
	public Vector3 myRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (new Vector3 (10, 15, 20) * Time.deltaTime);
		transform.Rotate (myRotation * Time.deltaTime);
		
	}
}
