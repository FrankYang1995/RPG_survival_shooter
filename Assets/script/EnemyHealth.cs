using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int health = 3;
	public int nowHealth;
	UnityEngine.AI.NavMeshAgent na;
	bool isTakeDamage;
	bool isDead;
	// Use this for initialization
	void Start () {
		nowHealth = health;
		na = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	float timer;
	void Update () {
		if (isTakeDamage) {
			na.speed = 1;
			timer += Time.deltaTime;
			if (timer >= 1) {
				na.speed = 2;
				timer = 0;
				isTakeDamage = false;
			}
		}
	}
	public void TakeDamage(int t){
		nowHealth -= t;
		isTakeDamage = true;
		if (nowHealth <= 0&&isDead != true) {
			isDead = true;
			Scoring.scoring ();
			Destroy (this.gameObject);
		}
	}
}
