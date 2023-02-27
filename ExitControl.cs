using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitControl : MonoBehaviour
{
    public GameObject Sure;
    public GameObject Menu;
    public GameObject MenuTool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Return"))
        {
            Sure.SetActive(false);
            Menu.SetActive(true);
            MenuTool.SetActive(true);
            
        }

        if (Input.GetButtonDown("Submit"))
        {
            
            Application.Quit();
            Debug.Log("lovleee");

        }
    }
}
