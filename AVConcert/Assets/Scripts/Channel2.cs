using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Channel2 : Channel {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Play ();
	}

	public override void Play(){
		Debug.Log ("play channel 2");
	}

	public override void Stop(){
		Debug.Log ("stop channel 2");
	}
}
