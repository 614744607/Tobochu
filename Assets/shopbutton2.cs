using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shopbutton2 : MonoBehaviour {
	public Text moneyText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame


	void Update() {
		moneyText.text="所持金:" + Score.Shokin.ToString() +"円" ;
	}	

	public void  r() {
		SceneManager.LoadScene ("start");	
	}

	public void u() {


		if (Score.Shokin > 100000) {
			Score.Shokin -= 100000;
			Shot.limit++;
			moneyText.text="所持金:" + Score.score.ToString()+"円" ;
			PlayerPrefs.SetFloat ("shokinKey", Score.Shokin);
			PlayerPrefs.SetInt ("Guns", Shot.limit);
			PlayerPrefs.Save ();
		}
	}
}
