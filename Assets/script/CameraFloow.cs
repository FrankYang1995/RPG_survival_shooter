using UnityEngine;
using System.Collections;

public class CameraFloow : MonoBehaviour {
	public Transform player;
	Vector3 diff;
	void Start () {
		diff = transform.position - player.position;
	}
	

	void Update () {
		if (player) {
			transform.position = diff + player.position;
		}
	}
}
