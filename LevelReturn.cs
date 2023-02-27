using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReturn : MonoBehaviour
{
    public GameObject LevelMenu;
    public GameObject LevelTool;
    public GameObject Mode;
    public GameObject ModeTool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Return"))
        {
            LevelMenu.SetActive(false);
            LevelTool.SetActive(false);
            Mode.SetActive(true);
            ModeTool.SetActive(true);
            
        }
    }
}
