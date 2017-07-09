using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour {

	public int eraseHunter;
	public int speedUp;

	// Use this for initialization
	void Start () {
		float getScore = PlayerPrefs.GetFloat ("eraseHunterKey");
		float getTanka = PlayerPrefs.GetFloat ("speedUpKey");
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetFloat ("eraseHunterkey", eraseHunter);
		PlayerPrefs.SetFloat ("speedUpKey", speedUp);
		PlayerPrefs.Save ();
	}

	void Shop(){
		//アイテムを買えるようにする　10万
	}
}
