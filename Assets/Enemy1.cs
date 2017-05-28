using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour {
	

	public Transform target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		//agent.SetDestination (target.position);
	}
}
