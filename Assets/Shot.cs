using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shot : MonoBehaviour {
	public static int limit;
	public Camera camera;
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		limit = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.L)) {
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
				if (limit > 0) {
					Destroy (hitInfo.collider.gameObject);
					limit = limit - 1;
				} else if (limit == 0) {
					
				}
			}
		}

	}
}
