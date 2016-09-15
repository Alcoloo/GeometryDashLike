using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;

    public Vector3 jumpForce = new Vector3(0.0f, 10.0f, 0.0f);

    public int rotateForce;

    private bool canJump;

    public Vector3 gravity = new Vector3(0.0f, -9.81f, 0.0f);

    public float coefJump;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Floor") canJump = true;
    }
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        transform.position += new Vector3(0.10f, 0.0f, 0.0f);
=======
        transform.position += new Vector3(0.5f, 0.0f, 0.0f);
        bool down = Input.GetKeyDown(KeyCode.Space);
        rb.AddForce(gravity);
        if (down && canJump)
        {
            canJump = false;
            rb.AddForce(jumpForce * coefJump, ForceMode.Impulse);
            rb.AddTorque(transform.forward * -rotateForce);
        }
>>>>>>> b1db144263a9a4fc7952febdb205004c760c3349
	}
}
