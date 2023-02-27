using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionFade : MonoBehaviour
{
    public GameObject MissionCanvas;
    public float missionDelay = 5f;
    

    float restartTimer;
    // Start is called before the first frame update
    void Awake()
    {
        

        
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            MissionCanvas.SetActive(false);
            Debug.Log("its working");

        }
    }
}
