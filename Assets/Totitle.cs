using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Totitle : MonoBehaviour {
	public Text runUIText;
	// Use this for initialization
	void Start () {
	//	runUIText.text = "賞金 : " + Runningtime.Shokincheck.ToString() + "円"; //表示して
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.S)) {
			SceneManager.LoadScene("start");
	}
}
}