using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearHunter1 : MonoBehaviour {
	public GameObject Hunter;
	public static GameObject A;
	public static GameObject B;
	public static GameObject C;
	public static GameObject D;
	public static GameObject E;


	public int m = 1;
	// Use this for initialization
	void Start () {
		Hunter = GameObject.Find ("Hnunter1"); // 探して保存する		
		Hunter.SetActive(false);
		A = GameObject.Find ("a");
		C = GameObject.Find("c");
		B = GameObject.Find("e");
		D = GameObject.Find("f");
		A.SetActive (false);
		B.SetActive (false);
		C.SetActive (false);
		D.SetActive (false);


	}

	
	// Update is called once per frame
	void Update () {
		if (Score.score > 50 & m == 1) {
			m = 0;
			Hunter.SetActive(true);
			A.SetActive (true);
			B.SetActive (true);
			C.SetActive (true);
			D.SetActive (true);
		}

	}
}
