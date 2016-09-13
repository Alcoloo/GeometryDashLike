using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    private Vector3 pos;
	void Start () {
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0.8f, 0.0f, 0.0f);
	}
}
