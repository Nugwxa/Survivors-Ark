using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralReturn : MonoBehaviour
{
    public GameObject General;
    public GameObject Controls;
    public GameObject ControllerImage;
    public GameObject KeyboardImage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            General.SetActive(false);
            Controls.SetActive(true);
            ControllerImage.SetActive(true);
            KeyboardImage.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            General.SetActive(false);
            Controls.SetActive(true);
            ControllerImage.SetActive(true);
            KeyboardImage.SetActive(false);
        }
    }
}
