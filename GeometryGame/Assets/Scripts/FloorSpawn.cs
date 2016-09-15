using UnityEngine;
using System.Collections;

public class FloorSpawn : MonoBehaviour {

    // Use this for initialization
    public GameObject lastChild;
    private Vector3 lastChildPosition;
    private float posPlayer;
	private float randomFloorPos;
    public GameObject floor;
	void Start () {
        lastChild = GameObject.FindWithTag("LastChildStart");
        lastChildPosition = lastChild.transform.position;
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
        if(lastChildPosition.x - 50.0f <= posPlayer)
        {
			FloorRandomSpawn (); 
        }
	}

	void FloorRandomSpawn()
	{
		randomFloorPos = Mathf.Floor(Random.Range (0, 3));
		if(randomFloorPos == 0)
		{
			floor.transform.position = new Vector3(lastChildPosition.x + 8.0f, 20.0f, 0.0f);
			GameObject.Instantiate(floor);
		}
		else if(randomFloorPos == 1)
		{
			floor.transform.position = new Vector3(lastChildPosition.x + 8.0f, -20.0f, 0.0f);
			GameObject.Instantiate(floor);
		}
		else 
		{
			floor.transform.position = new Vector3(lastChildPosition.x + 8.0f, 1.0f, -20.0f);
			GameObject.Instantiate(floor);
		}

		lastChild = floor;
		lastChildPosition = lastChild.transform.position;

	}
		
		
		
}
