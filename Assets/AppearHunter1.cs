using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearHunter1 : MonoBehaviour {
	public GameObject Hunter;
	public int m = 1;
	// Use this for initialization
	void Start () {
		Hunter = GameObject.Find ("Hnunter1"); // 探して保存する		
		Hunter.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score > 5 & m == 1) {
			m = 0;
			Hunter.SetActive(true);
		}
	}
}
