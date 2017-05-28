using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter5 : MonoBehaviour {

	public GameObject Hunter;
	public GameObject Hunter1;
	public GameObject Hunter2;
	public GameObject Hunter3;

	public int m = 1;
	// Use this for initialization
	void Start () {
		Hunter = GameObject.Find ("Hnunter5"); // 探して保存する
		Hunter1 = GameObject.Find ("Hnunter5 (1)"); // 探して保存する
		Hunter2 = GameObject.Find ("Hnunter5 (2)"); // 探して保存する
		Hunter3 = GameObject.Find ("Hnunter5 (3)"); // 探して保存する

		Hunter.SetActive(false);
		Hunter1.SetActive(false);
		Hunter2.SetActive(false);
		Hunter3.SetActive(false);

	}

	// Update is called once per frame
	void Update () {
		if (Score.score > 250 & m == 1) {
			m = 0;
			Hunter.SetActive(true);
			Hunter1.SetActive(true);
			Hunter2.SetActive(true);
			Hunter3.SetActive(true);

		}
	}
}
