using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {
	public static Text t;
	GameObject g;
	void Awake(){
		g = GameObject.FindGameObjectWithTag("scoring");
		if (g)
			t = g.GetComponent<Text> ();
	}
	static int a =0;
	public static void scoring(){
		a++;
		t.text = a.ToString ();
	}
}
