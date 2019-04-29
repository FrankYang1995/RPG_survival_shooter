using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public float timeAttack = 0.75f;
	public int attackDamage = 1;

	GameObject player;
	PlayerHealth playerHealth;
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player)
			playerHealth = player.GetComponent<PlayerHealth> ();
	}
		
	float timer;
	void OnTriggerStay(Collider g){
		if (g.CompareTag ("Player")) {
			timer += Time.deltaTime;
			if (timer >= timeAttack) {
				playerHealth.TakeDamage (attackDamage);
				timer = 0;
			}
		}
	}
	void OnTriggerExit(Collider g){
		if (g.CompareTag ("Player"))
			timer = 0;
	}
}
