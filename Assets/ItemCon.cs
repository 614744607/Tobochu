using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collider collision) {
		//Debug.Log ("物");
		string yourTag = collision.gameObject.tag;
		if(yourTag == "item"){
			//if (collision.CompareTag ("GameController")) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (this.gameObject);
		}
	}
}
