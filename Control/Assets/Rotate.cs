using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 myRotation;


	void Start () {

	}


	void Update () {
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
