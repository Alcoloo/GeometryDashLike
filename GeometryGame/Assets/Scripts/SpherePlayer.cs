using UnityEngine;
using System.Collections;

public class SpherePlayer : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;

    public Vector3 jumpForce = new Vector3(0.0f, -1.0f, 0.0f);

    private bool canJump;

    public bool jumped;

    public Vector3 gravity = new Vector3(0.0f, -9.81f, 0.0f);
    public Vector3 bouncing = new Vector3(0.0f, 10.0f, 0.0f);

    public float coefJump;

    void Start () {
        rb = GetComponent<Rigidbody>();
        jumped = false;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            canJump = true;
            if(jumped)rb.AddForce(bouncing*1.5f, ForceMode.VelocityChange);
            else rb.AddForce(bouncing, ForceMode.VelocityChange);
            jumped = false;
        }
    }

    // Update is called once per frame
    void Update () {
        bool down = Input.GetKeyDown(KeyCode.Space);
        rb.AddForce(gravity);
        if (down && canJump)
        {
            canJump = false;
            jumped = true;
            rb.AddForce(jumpForce * transform.position.y, ForceMode.Impulse);
        }
    }
}
