using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class Score : MonoBehaviour {
	// 時間を表示するUIText
	public Text scoreUIText;
	// 合計時間を表示するUIText
	public Text ShokinText;
	//public Text ItemText;
	public Text highScoreUIText;
	public Text ShokinPerSecUIText;
	public Text ItemNumberText;
	// 時間
	public static float score = 0;
	// 合計時間

	public static float Shokin = 0;
	public static float ShokinPerSec = 100;
	public static float highScore = 0;
	// PlayerPrefsで保存するためのキー


	// Use this for initialization
	void Start () { //保存されたデータを読み込む
		float getScore = PlayerPrefs.GetFloat ("shokinKey");
		float getTanka = PlayerPrefs.GetFloat ("PerSecKey");
		Shot.limit = PlayerPrefs.GetInt("Guns");
		if (getTanka < 50) {
			getTanka = 100;
		}
		Shokin = getScore;
		ShokinPerSec = getTanka;
		ShokinText.text = "賞金：" + Shokin.ToString() + "円";
		ShokinPerSecUIText.text = "1秒：" + ShokinPerSec.ToString() + "円";
		ItemNumberText.text = "銃の数:"+ Shot.limit.ToString() + "個";

		Cursor.visible = true;

	}
	
	// Update is called once per frame
	void Update () {
		ShokinText.text = "賞金：" + Shokin.ToString() + "円";
		ShokinPerSecUIText.text = "1秒：" + ShokinPerSec.ToString() + "円";
		if (score != 0) { //逃走時間0じゃないなら
			highScore = score + highScore;//逃走時間は先ほどの時間をプラスして
			if (score <= 299) {
				Shokin = Shokin + score * ShokinPerSec;
				highScoreUIText.text = "逃走時間 : " + score.ToString () + "秒"; //表示して
				ShokinPerSec -= 10;
				if (ShokinPerSec <= 40) {
					ShokinPerSec = 50;
				}
			} else {
				score = 300;
				Shokin = Shokin + 300 * ShokinPerSec;
				highScoreUIText.text = "逃走時間 : " + score.ToString () + "秒"; //表示して
				ShokinPerSec = ShokinPerSec + 50;
			}
			ShokinText.text = "賞金：" + Shokin.ToString() + "円";
			ShokinPerSecUIText.text = "1秒：" + ShokinPerSec.ToString() + "円";
			ItemNumberText.text = "銃の数:"+ Shot.limit.ToString() + "個";
			PlayerPrefs.SetFloat ("shokinKey", Shokin);
			PlayerPrefs.SetFloat ("PerSecKey", ShokinPerSec);
			PlayerPrefs.Save ();
			score = 0; //スコアを0にする
			}

		if (Input.GetKey (KeyCode.R)) {
			Shokin = 0;
			ShokinPerSec = 100;
			PlayerPrefs.SetFloat ("shokinKey", Shokin);
			PlayerPrefs.SetFloat ("PerSecKey", ShokinPerSec);
			PlayerPrefs.Save ();
			ShokinText.text = "賞金：" + Shokin.ToString() + "円";
			ShokinPerSecUIText.text = "1秒：" + ShokinPerSec.ToString() + "円";
		}		
		if (Input.GetKey (KeyCode.F)) {
			Shokin = 400000;
			ShokinPerSec = 500;
			PlayerPrefs.SetFloat ("shokinKey", Shokin);
			PlayerPrefs.SetFloat ("PerSecKey", ShokinPerSec);
			PlayerPrefs.Save ();
			ShokinText.text = "賞金：" + Shokin.ToString() + "円";
			ShokinPerSecUIText.text = "1秒：" + ShokinPerSec.ToString() + "円";
		}		



	}

		public void Save (){
			// ハイスコアを保存する

			//	Initialize ();
		} 
}