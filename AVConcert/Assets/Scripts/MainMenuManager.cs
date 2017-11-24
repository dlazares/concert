using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {
	// State
	float timer=10f;
	bool timerRunning=true;

	// UI Componenets
	public GameObject Background;
	Image BackgroundImage;
	public GameObject MainUI;

	void Start () {
		BackgroundImage = Background.GetComponent<Image> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (timerRunning) {
			if (timer > 0f) {
				Color c = BackgroundImage.color;
				c.a = Mathf.Lerp (c.a, 0f, .001f);
				BackgroundImage.color = c;
			} else {
				Background.SetActive (false);
				MainUI.SetActive (true);
				timerRunning = false;
			}
			timer -= Time.deltaTime;
		}
		
	}
}
