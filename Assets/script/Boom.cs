using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour {
	public float speed = 30;
	GameObject go;
	Vector3 v;
	int damage = 1;
	void Start () {
		v = transform.localScale;
	}
	float timer;
	bool isTrue =false;
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		timer += Time.deltaTime;
		if (timer >= 1.5f&&isTrue == false) {
			Destroy (this.gameObject);
		}
		if (isTrue) {
			damage = 3;
			if (go)
			transform.position = new Vector3 (go.transform.position.x, go.transform.position.y, go.transform.position.z - 1);
			if (go == null)
				Destroy (this.gameObject);
			if (timer >= 2) {
				transform.localScale = new Vector3 (v.x * 50, v.y * 50, v.z * 50);
			}
			if (timer >= 2.3f) {
				Destroy (this.gameObject);
			}
		}
	}
	void OnCollisionEnter(Collision g){
		if (g.collider. CompareTag ("enemy")) {
			g.collider.GetComponent<EnemyHealth> ().TakeDamage (damage);
			if (isTrue == false)
				go = g.collider.gameObject;
			isTrue = true;
		}
	}
}
