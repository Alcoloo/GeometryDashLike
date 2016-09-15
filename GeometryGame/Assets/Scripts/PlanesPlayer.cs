using UnityEngine;
using System.Collections;

public class PlanesPlayer : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;

    public Vector3 jumpForce = new Vector3(0.0f, 8.0f, 0.0f);

    public Vector3 gravity = new Vector3(0.0f, -5f, 0.0f);

    public float coefJump;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        bool down = Input.GetKeyDown(KeyCode.Space);
        rb.AddForce(gravity);
        if (down)
        {
            rb.AddForce(jumpForce, ForceMode.VelocityChange);
        }
    }
}
