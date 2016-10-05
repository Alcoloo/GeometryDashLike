using UnityEngine;
using System.Collections;

public class CubePlayer : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;

    public Vector3 jumpForce = new Vector3(0.0f, 10.0f, 0.0f);

    public int rotateForce;

    private bool canJump;

    public Vector3 gravity = new Vector3(0.0f, -9.81f, 0.0f);

    public float coefJump;

    public GameObject parent;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Floor") canJump = true;
    }


    // Update is called once per frame
    void Update () {
        transform.position = new Vector3 (parent.transform.position.x,transform.position.y,transform.position.z);
        bool down = Input.GetKeyDown(KeyCode.Space);
        rb.AddForce(gravity);
        if (down && canJump)
        {
            canJump = false;
            rb.AddForce(jumpForce * coefJump, ForceMode.Impulse);
            rb.AddTorque(transform.forward * -rotateForce);
        }
    }
}
