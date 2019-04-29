using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float force;
	public float speed;
	Vector3 movement;
	Rigidbody playerRigi;

	void Start () {
		playerRigi = GetComponent<Rigidbody> ();
	}
	Ray ray ;
	RaycastHit hit;
	Vector3 tagPos;
	void Update(){
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit, 100f, 1 << 8)) {
			tagPos = hit.point -transform.position;
			tagPos.y = 0;
			Quaternion q = Quaternion.LookRotation (tagPos);
			playerRigi.MoveRotation (q);
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			isMove = false;
			playerRigi.AddForce ((tagPos - transform.position)* force);
			isMove = true;
		}	
	}
	bool  isMove = true;
	void FixedUpdate () {
		
		float f = Input.GetAxisRaw ("Horizontal");
		float q = Input.GetAxisRaw ("Vertical");
		if (isMove)
		Move (f, q);
	}
	void Move(float f ,float q){
		movement.Set (f, 0f, q);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigi.MovePosition (transform.position + movement);
	}
}
