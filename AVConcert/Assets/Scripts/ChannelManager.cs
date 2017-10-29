using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelManager : MonoBehaviour {
	public List<Channel> channels;
	public int currentChannel = 0;

	void Start () {
		channels [0].gameObject.SetActive (true);
		channels [0].Play ();
		channels [0].Stop ();
		channels [0].Play ();
//		onChangeChannel (0);
	}
	

	void Update () {

	}

	void onChangeChannel(int channelNumber){
		for (var i = 0; i < channels.Count; i++) {
			channels [i].Stop ();
			channels [i].gameObject.SetActive (false);
		}
		channels [channelNumber].gameObject.SetActive (true);
		channels [channelNumber].Play ();
	}
}
