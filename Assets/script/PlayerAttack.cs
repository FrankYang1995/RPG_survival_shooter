using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public GameObject bullet;
	public Transform tagert;
	public AudioClip ac;

	AudioSource a;
	void Start () {
		a = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (bullet, tagert.position, tagert.rotation);
			a.clip = ac;
			a.Play ();
		}
	}
}
