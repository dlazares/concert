using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Channel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void Play(){
		Debug.Log ("playing");
	}

	public virtual void Stop(){
		Debug.Log ("stop playing");

	}
}
