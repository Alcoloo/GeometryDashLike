using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public GameObject player;

	private float offsetX;
	// Use this for initialization
	void Start () {
		offsetX = transform.position.x - player.transform.position.x;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (player.transform.position.x + offsetX, transform.position.y, transform.position.z);
	}
}
