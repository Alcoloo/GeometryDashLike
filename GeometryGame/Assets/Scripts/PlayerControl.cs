using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0.5f, 0.0f, 0.0f);
    }
}
