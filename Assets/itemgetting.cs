using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemgetting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hit){
		if (hit.gameObject.tag == "item") {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (hit.gameObject);
		}
		/*if (hit.gameObject == AppearHunter1.B) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (AppearHunter1.B.gameObject);
		}
		if (hit.gameObject == AppearHunter1.C) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (AppearHunter1.C.gameObject);
		}
		if (hit.gameObject == AppearHunter1.D) {
			Debug.Log ("高麗人参");
			Shot.limit = Shot.limit + 1;
			Destroy (AppearHunter1.D.gameObject);
		}*/

	}
}
