using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 30;

	void Start () {
	
	}
	float timer;

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		timer += Time.deltaTime;
		if (timer >= 1.5f) {
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter(Collision g){
		if (g.collider. CompareTag ("enemy")) {
			g.collider.GetComponent<EnemyHealth> ().TakeDamage (1);
			Destroy (this.gameObject);
		}
	}
}
