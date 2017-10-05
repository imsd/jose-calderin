using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
		public string FileName = "whatever.png";

		void Update () {

			// if user presses the S key
			if(Input.GetKeyDown("s")) {

				// log it and capture the screen shot!
				Debug.Log ("screenshot captured!");

				ScreenCapture.CaptureScreenshot(FileName);
			}
		}
	}