using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public GameObject SoundEditUI;
	public GameObject MainUI;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenSoundEdit(){
		MainUI.SetActive (false);
		SoundEditUI.SetActive (true);
	}

	public void CloseSoundEdit(){
		MainUI.SetActive (true);
		SoundEditUI.SetActive (false);
	}
}
