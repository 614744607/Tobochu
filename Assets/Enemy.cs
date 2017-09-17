using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
	public float speed = 20f;
	private float rotationSmooth ;
	private Vector3 targetPosition;
	//public float changeTargetSqrDistance = 15f;
	public GameObject target;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		//agent = GetComponent<NavMeshAgent>();
		target = GameObject.Find("FPSController");
		Debug.Log (target);
	}

	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
	}

	void OnTriggerEnter(Collider target) {
		if (target.CompareTag("GameController")) {
			Debug.Log ("A");
			PlayerPrefs.SetInt ("Guns", Shot.limit);
			PlayerPrefs.Save ();
			SceneManager.LoadScene("gameovera");

		}
	}
}