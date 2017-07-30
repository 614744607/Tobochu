using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collider A) {
		//Debug.Log ("物");
		if(A.gameObject.CompareTag("GameController")){
			//if (collision.CompareTag ("GameController")) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (AppearHunter1.C.gameObject);
		}
	}
}
