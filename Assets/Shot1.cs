using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot1 : MonoBehaviour {
	public Camera camera;
	public GameObject Hunter;
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Y)) {
			Shoot ();

		}	
	}

	void Shoot(){
		int distance = 5000;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = camera.ScreenPointToRay(center);
		RaycastHit hitInfo;

		if (Physics.Raycast (ray, out hitInfo, distance)) {
			if (hitInfo.collider.tag == "Hunter") {
				//スピードを下げる

			}

		}

	}
}
