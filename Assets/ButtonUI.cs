using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour {
	int x = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ButtonPush() {

		if (Score.Shokin >= 100000) {
			float x = PlayerPrefs.GetInt ("ment");
			Score.Shokin = Score.Shokin - 100000;
			PlayerPrefs.SetFloat ("shokinKey", Score.Shokin);
			PlayerPrefs.SetFloat ("PerSecKey", Score.ShokinPerSec);
			PlayerPrefs.Save ();
			if (x == 0) {
				SceneManager.LoadScene ("shinokin");
			}if (x == 1){
				SceneManager.LoadScene("noname");
		}
	}
	}
}
