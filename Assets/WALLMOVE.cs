using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALLMOVE : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Score.score >= 105) {
			transform.position += new Vector3(30f*Time.deltaTime, 0f, 0f);
		}

		if(Score.score >= 125){
			Destroy(this.gameObject);
		}
	}
}
