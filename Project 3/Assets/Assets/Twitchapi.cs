using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitchapi : MonoBehaviour {

	public string url = "http://tmi.twitch.tv/group/user/imaqtpie/chatters";
	IEnumerator Start() {

		// fetch the actual info, like you would from a browser
		WWW www = new WWW (url);

		// yield return waits for the download to complete before proceeding
		// but since this is in IEnumerator it wont stall the program outright
		yield return www;

		// use a JSON Object to store the info temporarily
		// this makes it easy to access the data struture
		JSONObject tempData = new JSONObject (www.text);



		JSONObject chatters = tempData ["chatters"];
		JSONObject moderators = chatters ["moderators"];
		JSONObject viewers = chatters ["viewers"];
		int viewercount = viewers.Count;

		Debug.Log(moderators[0]);
        Debug.Log(viewercount.ToString());
       


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
