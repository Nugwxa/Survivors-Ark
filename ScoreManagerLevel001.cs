using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLevel001 : MonoBehaviour
{
    public static int score;


    Text text;


    

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }


    void Update()
    {
        text.text = "" + score;

    }
}
