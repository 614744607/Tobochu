using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter4 : MonoBehaviour {

	public GameObject Hunter;
	public int m = 1;
	// Use this for initialization
	void Start () {
		Hunter = GameObject.Find ("Hnunter4"); // 探して保存する		
		Hunter.SetActive(false);		
	}

	// Update is called once per frame
	void Update () {
		if (Score.score > 200 & m == 1) {
			m = 0;
			Hunter.SetActive(true);
		}
	}
}
