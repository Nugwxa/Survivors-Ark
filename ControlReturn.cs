using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlReturn : MonoBehaviour
{
    public GameObject Select;
    public GameObject Menu;
    public GameObject BDisable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Return"))
        {
            Select.SetActive(false);
            Menu.SetActive(true);
            BDisable.SetActive(false);

        }
    }
}
