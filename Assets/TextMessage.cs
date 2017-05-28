using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	// uGUIの機能を使うお約束

public class TextMessage : MonoBehaviour {
	
	public string[] scenarios; // シナリオを格納する
	public Text uiText;	// uiTextへの参照を保つ
	int currentLine = 0; // 現在の行番号

	// Use this for initialization
	void Start () {
		TextUpdate();
	}
	
	// Update is called once per frame
	void Update () {
		if(currentLine < scenarios.Length && Input.GetMouseButtonDown(0))
		{
			TextUpdate();
		}
		if(currentLine == scenarios.Length && Input.GetMouseButtonDown(0))
		{
			GameObject gameObject = GameObject.Find("AAAA");
			gameObject.SetActive(false);
		}


	}
	void TextUpdate()
	{
		// 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
		uiText.text = scenarios[currentLine];
		currentLine ++;
	}
}
