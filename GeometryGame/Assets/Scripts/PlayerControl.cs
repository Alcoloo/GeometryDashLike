using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public GameObject currentForm;
    public GameObject cube;
    public GameObject sphere;
    public GameObject plane;

    public GameObject level;

    private int distance;

    // Use this for initialization
    void Start () {
        currentForm = cube;
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance = (int)Mathf.Floor(-level.transform.position.x);

        if (distance > 20)
        {
            cube.SetActive(false);
            sphere.SetActive(true);
            currentForm = sphere;
        }
        if (distance > 50)
        {
            sphere.SetActive(false);
            plane.SetActive(true);
            currentForm = plane;
        }
        if (distance > 80)
        {
            plane.SetActive(false);
            cube.SetActive(true);
            currentForm = cube;
        }

    }

    }
