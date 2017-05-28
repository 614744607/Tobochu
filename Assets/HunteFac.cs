using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunteFac : MonoBehaviour {
	private int m = 0;
	public GameObject button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Score.score >=30f && m == 0){
			Debug.Log ("Hello");
			Instantiate(button,new Vector3(180f,50f,102f),Quaternion.Euler(0, 0, 0));
			//Mission1a = Resources.Load("Tiger") as GameObject;
			//Tiger = (GameObject) Instantiate(Mission1a,new Vector3(-85.04f,21,159),Quaternion.Euler(0, 0, 0));
			m = 1;

	}

	}

}
