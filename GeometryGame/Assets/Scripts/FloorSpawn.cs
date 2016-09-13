using UnityEngine;
using System.Collections;

public class FloorSpawn : MonoBehaviour {

    // Use this for initialization
    public GameObject lastChild;
    private Vector3 lastChildPosition;
    private float posPlayer;
    public GameObject floor;
	void Start () {
        lastChild = GameObject.FindWithTag("LastChildStart");
        lastChildPosition = lastChild.transform.position;
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
        if(lastChildPosition.x - 100.0f <= posPlayer)
        {
            GameObject.Instantiate(floor);
            floor.transform.position = new Vector3(lastChildPosition.x + 8.0f, lastChildPosition.y, lastChildPosition.z);
            lastChild = floor;
            lastChildPosition = lastChild.transform.position;
        }
	}
}
