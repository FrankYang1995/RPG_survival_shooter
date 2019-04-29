using UnityEngine;
using System.Collections;

public class PlayerSkills : MonoBehaviour {

	public GameObject go;
	public Transform taget;
	public GameObject go2;
	public Transform taget2;
	public AudioClip ac;

	AudioSource a;
	void Start () {
		a = GetComponent<AudioSource> ();
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Instantiate (go, taget.position, taget.rotation);
			a.clip = ac;
			a.Play ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Instantiate (go2, taget2.position, taget2.rotation);
		}
	}
}
