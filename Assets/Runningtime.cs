using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Runningtime : MonoBehaviour {


	public Text timeUIText;
	public Text ShokinUIText;
//	public int Mission1 = 0;
	int a = 0;

	// Use this for initialization
	public float runTime;
	public float Shokincheck;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score >= 280 && a == 0) {
			GameObject gameObject = GameObject.Find("Jama");
			gameObject.SetActive(false);
			a = a + 1;
		}





		Score.score = Time.deltaTime + Score.score;
		float Shokincheck = Score.score * Score.ShokinPerSec;
		timeUIText.text = "逃走時間 : " + Score.score.ToString ("F0") + "秒"; //表示して
		ShokinUIText.text = "賞金 : " + Shokincheck.ToString ("F0") + "円"; //表示して
		if (Score.score >= 300) {
			Score.score = 300;
			SceneManager.LoadScene ("tososeikou");

		}



		if (Input.GetKey (KeyCode.Q)) {
			Score.score = 290;
		}	
		if (Input.GetKey (KeyCode.E)) {
			Score.score = 270;
		}	
		if (Input.GetKeyDown(KeyCode.X)) {
			Score.score += 50;
		}	


			}



}
	
