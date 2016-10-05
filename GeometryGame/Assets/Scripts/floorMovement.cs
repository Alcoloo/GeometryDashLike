using UnityEngine;
using System.Collections;

public class floorMovement : MonoBehaviour {

	private float floorSpeed = 15;
	private string popDirection;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		correctString ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (popDirection == "up") {
			rb.AddForce ((transform.up * -1) * floorSpeed);
			if (transform.position.y <= 1) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, 1.0f, transform.position.z);
				rb.isKinematic = true;
			} 
		}
		else if (popDirection == "down") {
			rb.AddForce ((transform.up) * floorSpeed);
			if (transform.position.y >= 1) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, 1.0f, transform.position.z);
				rb.isKinematic = true;
			}
		}
		else if(popDirection == "forward") {
			rb.AddForce (transform.forward * floorSpeed);
			if (transform.position.z >= 0) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, transform.position.y, 0.0f);
				rb.isKinematic = true;
			}
		}
	}

	void correctString () {
		if (transform.position.y >= 0 && transform.position.z == 0)
			popDirection = "up";
		else if (transform.position.y <= 0 && transform.position.z == 0)
			popDirection = "down";
		else if (transform.position.z <= 0)
			popDirection = "forward";
	}		
}