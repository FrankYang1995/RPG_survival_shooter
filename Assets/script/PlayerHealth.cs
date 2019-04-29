using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public Slider slider;
	public float health = 3;
	public float nowHealth;
	public GameObject gameover;

	PlayerMove playmove;
	bool isDead;
	float timer;
	void Start () {
		playmove = GetComponent<PlayerMove> ();
		nowHealth = health;
		slider.value = nowHealth / health;
	}

	public void TakeDamage(int t){
		nowHealth -= t;
		slider.value = nowHealth / health;
		if (nowHealth <= 0&&isDead ==false) {
			Dead ();
		}
	}
	void Dead(){
		isDead = true;
		Destroy (this.gameObject);
		Time.timeScale = 0;
		gameover.SetActive (true);
	}
}
