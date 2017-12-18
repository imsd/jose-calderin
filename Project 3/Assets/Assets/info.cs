using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour {


		// assign the game objects that will be animated
		public Transform Shape1;


		// beginning property for shapes
		public Vector3 startingValue;

		// ending properties for shapes
		public Vector3 TargetValue1;


		// keep track of time
		public float AnimationLength = 3f;

		// text object
		//public TextMesh DisplayText;

		// Use this for initialization
		void Start () {

			// as an alternative to assigning in the inspector,
			// assign by finding names of game objects
			Shape1 = GameObject.Find ("Shape (1)").transform;


			//DisplayText = GameObject.Find ("Display Text").GetComponent<TextMesh>();

			// set all scales to starting value
			Shape1.transform.localScale = startingValue;

		}

		// Update is called once per frame
		void Update () {

			// what total is that as a proportion?
			float Proportion = Time.time / AnimationLength;

			// animate using "Lerp" function which moves between two values smoothly
			Shape1.transform.localScale = Vector3.Lerp (startingValue, TargetValue1, Proportion);

			// do something with the text display
			// convert the Proportion (zero to one) to a percentage (0 to 100)
			int Percentage = (int)Mathf.Round((Proportion * 100));
			// clamp it so it doesnt exceed 100
			Percentage = Mathf.Clamp (Percentage, 0, 100);
			// add a % symbol on the end
			string PercentageString = Percentage.ToString() + "%";
			// set the display text to that value
			//DisplayText.text = PercentageString;
		}
	}
