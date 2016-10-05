using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    public Color color;

    Text text;

    void Awake()
    {
        color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        text = GetComponent<Text>();
        text.color = color;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += 1;
        text.text = "Score : " + score;
    }
}
