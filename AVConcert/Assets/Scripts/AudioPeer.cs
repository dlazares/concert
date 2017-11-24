using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour {
AudioSource _audioSource;
	public static float[] _samples = new float[512];
	public static float[] _freqBand = new float[8];
	string microphone;
// Use this for initialization
	void Start () 
	{
		_audioSource = GetComponent<AudioSource> ();
		// Get Available Microhpones
		foreach (string device in Microphone.devices) {
			if (microphone == null) {
				Debug.LogFormat ("{0} is an available microphone", device);
				microphone = device;
			}
		}
		_audioSource.clip = Microphone.Start(microphone, true, 10, 44100);
		_audioSource.loop = true;
		while(!(Microphone.GetPosition(null) > 0 )) {}
		_audioSource.Play();

	}
	
	// Update is called once per frame
	void Update () {
		GetSpectrumAudioSource ();
		MakeFrequnecyBands();

		
	}

	void GetSpectrumAudioSource(){

		_audioSource.GetSpectrumData (_samples, 0, FFTWindow.Blackman); 
	}

	void MakeFrequnecyBands(){

		/* Some complicated calculation to come out with 8 frequnecy bands
		 * 22050Hertz / 512 bands = 43Hertz/sample
		 * 0 - 2 = 86 hrtz
		 * 1 - 4 = 172hrtz ... 87 -258hertz
		 * 2 - 8 = 344... 259 - 602 hertz
		 * 3 - 16 = 688 hertz.. 603-1290hertz
		 * 4 - 32 = 1376 hertz .. 1291-2666hertz
		 * 5 - 64 = 2667-5418hertz
		 * 6 - 128 = 5419-1092
		 * 7 - 256 = 1093 - 219030 
		 * need to add 2 to the last band to make it 512
		 */

		int count = 0;
		for (int i = 0; i < 8; i++) {
			float average = 0;
			int sampleCount = (int)Mathf.Pow(2,i) * 2;
			if (i == 7) {
				sampleCount += 2;
			}
			for (int j = 0; j < sampleCount; j++) {
				average += _samples[count] * (count + 1);
					count++;
			}
			average /= count;
			_freqBand[i] = average * 10;
//			Debug.Log (_freqBand [i]);

		}
	}
}	