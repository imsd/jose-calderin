using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayString : MonoBehaviour {

	public string[] names;
	public string[] places;
	public string[] game;
	public string[] day;
	public string[] song;


	void Start () {

		// loop thru all the names
		//        for (int i = 0; i < names.Length; i++) {
		//            Debug.Log (names [i]);
		//        }

		// draw a random name from the array
		//        int rando = Random.Range(0, names.Length);
		//        Debug.Log (names [rando]);

		// get a random number from 0 to the number of nouns available
		int randNoun = Random.Range(0, names.Length);
		int randPlace = Random.Range(0, places.Length);
		int randGame = Random.Range(0, game.Length);
		int randDay = Random.Range(0, day.Length);
		int randSong = Random.Range(0, song.Length);

		//string line1 = "One day, " + names [randNoun] + " went to " + 
		//places[randPlace] + ".";
		string line1 = "One " + day [randDay] + ", " + names [randNoun] + " was singing " + 
			song [randSong] + " while playing " + game [randGame] + " at " + places[randPlace] + ".";
		// actually print out the madlib
		Debug.Log (line1);


	}

	// Update is called once per frame
	void Update () {

	}
}