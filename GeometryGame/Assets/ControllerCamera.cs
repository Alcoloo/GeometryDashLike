using UnityEngine;
using System.Collections;

public class ControllerCamera : MonoBehaviour {

    // Use this for initialization
    public GameObject player;

    private float offsetX;
	void Start () {
        offsetX = transform.position.x - player.transform.position.x;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(player.transform.position.x + offsetX, transform.position.y, transform.position.z);
	}
}
