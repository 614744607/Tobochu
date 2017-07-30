using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider hit){
		Debug.Log("Hello");
		if (hit.CompareTag ("GameController")) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (gameObject);
		}
		if (hit.CompareTag ("MainCamera")) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (gameObject);
		}
	}
}
