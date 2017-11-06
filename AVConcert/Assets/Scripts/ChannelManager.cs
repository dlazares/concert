using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelManager : MonoBehaviour {
	public List<Channel> channels;
	public int currentChannel = 0;
	public GameObject ChannelListUI;
	public GameObject MainUI;

	void Start () {
		channels [0].gameObject.SetActive (true);
		channels [0].Play ();
		channels [0].Stop ();
		channels [0].Play ();
//		onChangeChannel (0);
	}
	

	void Update () {

	}

	public void onChangeChannel(int channelNumber){
		for (var i = 0; i < channels.Count; i++) {
			channels [i].Stop ();
			channels [i].gameObject.SetActive (false);
		}
		channels [channelNumber].gameObject.SetActive (true);
		channels [channelNumber].Play ();
	}

	public void onCloseChannelList(){
		MainUI.SetActive (true);
		ChannelListUI.SetActive (false);
	}

	public void onOpenChannelList(){
		MainUI.SetActive (false);
		ChannelListUI.SetActive (true);
	}

}
