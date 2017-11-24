using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;
public class Channel3_new : Channel {
	public Shader GlitchShader;
	public Shader MoshShader;
	Glitch_Channel3 glitch_3;
	Moshing_Channel3 mosh_3;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void Play(){
		Debug.Log ("play channel 3");
		//		Debug.Log (AudioPeer._freqBand [AudioPeer._freqBand.Length/2]);
		glitch_3 = Camera.main.gameObject.AddComponent<Glitch_Channel3>();
		mosh_3 = Camera.main.gameObject.AddComponent<Moshing_Channel3> ();
		glitch_3._shader = GlitchShader;
		mosh_3._shader = MoshShader;
		//Debug.Log (glitch_3._shader);
	}

	public override void Stop(){
		Destroy (Camera.main.gameObject.GetComponent<Glitch_Channel3> ());
		Destroy (Camera.main.gameObject.GetComponent<Moshing_Channel3> ());
		Debug.Log ("stop channel 3");
	}
}
