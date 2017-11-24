using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;
public class Channel1 : Channel {
	public Shader digitalGlitchShader;
	public DigitalGlitch glitch;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (glitch != null) {
			glitch.intensity = (AudioPeer._freqBand [0]+AudioPeer._freqBand[1]+AudioPeer._freqBand[2])*2;
			Debug.Log (glitch.intensity);
		}
	}

	public override void Play(){
		Debug.Log ("play channel 1");
		glitch = Camera.main.gameObject.AddComponent<DigitalGlitch>();
		glitch._shader = digitalGlitchShader;
	}

	public override void Stop(){
		Destroy (Camera.main.gameObject.GetComponent<DigitalGlitch> ());
		Debug.Log ("stop channel 1");
	}
}
