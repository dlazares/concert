using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;

public class Channel2 : Channel {

	public Shader glitchShader;
	Glitch glitch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

//	public override void Play(){
//		Debug.Log ("play channel 2");
//	}
//
//	public override void Stop(){
//		Debug.Log ("stop channel 2");
//	}

	public override void Play(){
		Debug.Log ("play channel 2");
//		Debug.Log (AudioPeer._freqBand [AudioPeer._freqBand.Length/2]);
		glitch = Camera.main.gameObject.AddComponent<Glitch>();
		glitch._shader = glitchShader;
//		Debug.Log (glitch._shader);
	}

	public override void Stop(){
		Destroy (Camera.main.gameObject.GetComponent<Glitch> ());
		Debug.Log ("stop channel 2");
	}
}
