using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exeat : MonoBehaviour
{
    public GameObject MainTool;
    public GameObject Ex;
    public GameObject ExTool;
    public GameObject Bbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Return"))
        {
            MainTool.SetActive(false);
            Ex.SetActive(true);
            Bbutton.SetActive(false);
            ExTool.SetActive(true);
            
        }
    }
}
