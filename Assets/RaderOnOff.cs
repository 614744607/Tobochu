using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaderOnOff : MonoBehaviour {
	public int Rader = 1; //最初は見えてる(0:見えてない　1:見えてる)
	public Renderer rend;
	public GameObject Rader1;

	// Use this for initialization
	void Start () {
		Rader1 = GameObject.Find ("Rader"); // 探して保存する
	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKeyDown (KeyCode.Z)) {
			if (Rader == 0) { //見えてない時は見えるようにする        
				Rader1.SetActive(true);
				Rader = 1;
			} else if (Rader == 1) { //見えてる時は見えないようにする
				Rader1.SetActive(false);
				Rader = 0;
			}
		}

	}
}
