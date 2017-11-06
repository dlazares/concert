
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;
public class Channel3 : Channel {
	public Shader digitalGlitchShader;
	public DigitalGlitch glitch;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (glitch != null) {
			float total = 0f;
			foreach (float val in AudioPeer._freqBand) {
				total += val;
			}
			glitch.intensity = AudioPeer._freqBand [4]/total;
		}
	}

	public override void Play(){
		Debug.Log ("play channel 1");
//		Debug.Log (AudioPeer._freqBand [AudioPeer._freqBand.Length/2]);
		glitch = Camera.main.gameObject.AddComponent<DigitalGlitch>();
		glitch._shader = digitalGlitchShader;
		Debug.Log (glitch._shader);
	}

	public override void Stop(){
		Destroy (Camera.main.gameObject.GetComponent<DigitalGlitch> ());
		Debug.Log ("stop channel 1");
	}
}
