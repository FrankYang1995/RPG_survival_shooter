using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	float timer;
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2) {
			Destroy (this.gameObject);
		}
	}
}
