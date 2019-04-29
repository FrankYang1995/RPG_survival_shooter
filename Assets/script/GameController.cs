using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	public GameObject enemy;
	public Transform taget1;
	public Transform taget2;
	public Text time;
	public GameObject win;

	float timer;
	float timer2;
	int s;
	void Start () {
	
	}
	

	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2) {
			Instantiate (enemy, taget1.position, Quaternion.identity);
			Instantiate (enemy, taget2.position, Quaternion.identity);
			timer = 0;
		}
		timer2 += Time.deltaTime;
		if (timer2 >= 1) {
			s++;
			time.text = s.ToString ();
			if (s >= 600) {
				win.SetActive (true);
				Time.timeScale = 0;
			}
			timer2 = 0;
		}
	}
}
