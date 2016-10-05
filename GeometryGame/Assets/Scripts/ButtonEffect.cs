using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonEffect : MonoBehaviour {

    public void OnClick()
    {
        GetComponent<Image>().CrossFadeAlpha(0.1f, 10.0f, true);
        Destroy(gameObject);
        GameObject.FindWithTag("score").AddComponent<ScoreManager>();
        
    }
}
