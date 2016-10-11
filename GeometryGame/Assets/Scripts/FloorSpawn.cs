using UnityEngine;
using System.Collections;

public class FloorSpawn : MonoBehaviour {

    // Use this for initialization
    public GameObject lastChild;
    private Vector3 lastChildPosition;
    private float posPlayer;
	private float randomFloorPos;
    private float randomFloor;
    public GameObject floor;
    public GameObject[] floors;
    private GameObject newFloor;
    public float scrollingSpeed;
    public float deltaTime;
	void Start () {
        lastChild = GameObject.FindWithTag("LastChildStart");
        lastChildPosition = lastChild.transform.position;
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
        deltaTime = 7.8f/(scrollingSpeed*60);
        StartCoroutine(DoSpawn());
    }
	
    void Update()
    {
        transform.position -= new Vector3(scrollingSpeed, 0, 0);
    }

	void FixedUpdate () {
        posPlayer = GameObject.FindWithTag("Player").transform.position.x;
    }

    public IEnumerator DoSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(deltaTime);
            FloorRandomSpawn();
        }
    }
    

	void FloorRandomSpawn()
	{
		randomFloorPos = Mathf.Floor(Random.Range (0, 3));
        randomFloor = Random.Range(0, floors.Length);
        floor = floors[(int)randomFloor];
		if(randomFloorPos == 0)
		{
			
            newFloor = GameObject.Instantiate(floor);
            newFloor.transform.parent = transform;
            newFloor.transform.position = new Vector3(48.0f, 20.0f, 0.0f);

        }
		else if(randomFloorPos == 1)
		{
			
            newFloor = GameObject.Instantiate(floor);
            newFloor.transform.parent = transform;
            newFloor.transform.position = new Vector3(48.0f, -20.0f, 0.0f);
        }
		else 
		{
			
            newFloor = GameObject.Instantiate(floor);
            newFloor.transform.parent = transform;
            newFloor.transform.position = new Vector3(48.0f, 1.0f, -20.0f);
        }
		lastChild = newFloor;
		lastChildPosition = newFloor.transform.position;

    }
		
		
		
}
