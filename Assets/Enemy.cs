using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
	private float speed = 20f;
	private float rotationSmooth = 1.5f;
	private Vector3 targetPosition;
	private float changeTargetSqrDistance = 15f;
	public GameObject target;

	UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	
	// Update is called once per frame
	void Update () {
		//agent.destination = target.transform.position;

		// 目標地点との距離が小さければ、次のランダムな目標地点を設定する
		//float sqrDistanceToTarget = Vector3.SqrMagnitude(transform.position - targetPosition);
		//if (sqrDistanceToTarget < changeTargetSqrDistance)
		{
			targetPosition = GetRandomPositionOnLevel();
		}

		// 目標地点の方向を向く
		Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

		// 前方に進む
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	public Vector3 GetRandomPositionOnLevel()
	{
		float levelSize = 15f;
		return new Vector3(Random.Range(-levelSize, levelSize), 0, Random.Range(-levelSize, levelSize));
	}

	void OnTriggerEnter(Collider target) {
		if (target.CompareTag("GameController")) {
			Debug.Log ("A");
			SceneManager.LoadScene("gameovera");
			}
}
}