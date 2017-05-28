using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.S)) {
			SceneManager.LoadScene("メイン");
		}
		if (Input.GetKey (KeyCode.T)) {
			if (Score.Shokin >= 300000) {
				SceneManager.LoadScene ("Stafe2");
			}		
		}
	}
}
