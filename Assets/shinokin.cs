using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class shinokin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Capture ();
	//	UnityEditor.EditorUtility.DisplayDialog("画像を保存しました", "しのきん.png", "わかりました");
		SceneManager.LoadScene("start");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Capture()
	{
		ScreenCapture.CaptureScreenshot("しのきん.png");
	}
}
