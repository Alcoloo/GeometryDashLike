using UnityEngine;
using System.Collections;

public class floorMovement : MonoBehaviour {

	private float floorSpeed = 10;
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
            transform.position = new Vector3(transform.position.x, transform.position.y-floorSpeed*0.1f, transform.position.z);
			if (transform.position.y <= 1) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, 1.0f, transform.position.z);
			} 
		}
		else if (popDirection == "down") {
            transform.position = new Vector3(transform.position.x, transform.position.y + floorSpeed * 0.1f, transform.position.z);
            if (transform.position.y >= 1) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, 1.0f, transform.position.z);
			}
		}
		else if(popDirection == "forward") {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + floorSpeed*0.1f);
            if (transform.position.z >= 0) {
				rb.velocity = Vector3.zero;
				transform.position = new Vector3 (transform.position.x, transform.position.y, 0.0f);
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