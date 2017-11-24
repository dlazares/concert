using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public GameObject SoundEditUI;
	public GameObject ChannelList;

	public void OnAudioControlClick(){
		Debug.Log ("audio control clicked");
		SoundEditUI.SetActive (!SoundEditUI.active);
		ChannelList.SetActive (!ChannelList.active);
	}
}
