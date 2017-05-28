using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission1 : MonoBehaviour {
	private int m = 0;
	private GameObject Button;
	private GameObject button;
	private GameObject Mission1a;
	private GameObject Tiger;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Score.score >= 10 && m == 0){
Button = Resources.Load("button") as GameObject;
button = (GameObject) Instantiate(Button,new Vector3(-211.2f,-2.6f,180.6f),Quaternion.Euler(0, 0, 0));
//Mission1a = Resources.Load("Tiger") as GameObject;
//Tiger = (GameObject) Instantiate(Mission1a,new Vector3(-85.04f,21,159),Quaternion.Euler(0, 0, 0));
m = 1;
}
		}
	}
