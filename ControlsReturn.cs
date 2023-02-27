using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsReturn : MonoBehaviour
{
    public GameObject General;
    public GameObject Controls;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Controls.SetActive(false);
            General.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button4))
        {
            Controls.SetActive(false);
            General.SetActive(true);
        }
    }
}
