﻿
using UnityEngine;
using System.Collections;

public class Movie : MonoBehaviour {

	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		movie = ((MovieTexture)GetComponent<Renderer>().material.mainTexture);
		movie.Play ();
	}

	// Update is called once per frame
	void Update () {

	}


}