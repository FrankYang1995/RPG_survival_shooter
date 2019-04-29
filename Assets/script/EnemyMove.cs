using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	Transform player;
	UnityEngine.AI.NavMeshAgent na;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		na = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	void Update () {
		if (player) {
			na.SetDestination (player.position);//设置目标
		}
	}
}
