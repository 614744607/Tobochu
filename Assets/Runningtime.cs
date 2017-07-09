using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Runningtime : MonoBehaviour {
	public Camera camera;

	public Text timeUIText;
	public Text ShokinUIText;
//	public int Mission1 = 0;
	public Text itemText;
	public Text EText;
	public Text PText;


	public static int energyDrink;
	int a = 0;

	// Use this for initialization
	public float runTime;
	public float Shokincheck;
	public float dushtime;
	public GameObject enemyObjects;
	public int enemyNum;

	public int Itemused = 0;
	private GameObject nearObj;         //最も近いオブジェクト
	void Start () {
		UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed = 40f;
		UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed = 20f;
		energyDrink = 5;
		//Itemget.target = GameObject.FindWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {

		//enemyObjects = GameObject.FindGameObjectsWithTag ("Hnunter");
		//enemyNum = enemyObjects.Length;

			
		if (Score.score >= 280 && a == 0) {
			GameObject gameObject = GameObject.Find("Jama");
			gameObject.SetActive(false);
			a = a + 1;
			Shot.limit = Shot.limit + 7;
		}



		Score.score = Time.deltaTime + Score.score;
		float Shokincheck = Score.score * Score.ShokinPerSec;
		timeUIText.text = "逃走時間 : " + Score.score.ToString ("F0") + "秒"; //表示して
		ShokinUIText.text = "賞金 : " + Shokincheck.ToString ("F0") + "円"; //表示して
		itemText.text="ハンター消滅銃(L):" + Shot.limit.ToString("F0")+"個" ;
		EText.text="魔剤(P):" + energyDrink.ToString("F0")+"本" ;
//		PText.text="";



		if (Score.score >= 300) {
			Score.score = 300;
			SceneManager.LoadScene ("tososeikou");

		}


		if (Input.GetKeyDown (KeyCode.R) & Itemused == 0) { //Rが押された時
			Score.score = Score.score + 10; //10秒だけ逃げ切る時間を減らせる
			Itemused = Itemused + 1;
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
		if (Input.GetKeyDown(KeyCode.P)) {
			if (energyDrink>0)
				UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed = UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_RunSpeed * 1.5f;
				UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed = UnityStandardAssets.Characters.FirstPerson.FirstPersonController.m_WalkSpeed * 1.5f;
				energyDrink -= 1;
		}	else{
			
		}




			}



}
	
