using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsReturn : MonoBehaviour
{
    public GameObject Setting;
    public GameObject MainMenu;
    public GameObject MainMenuTool;
    public GameObject MainExitController;
    public GameObject A;
    public GameObject CurrentBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Return"))
        {
            Setting.SetActive(false);
            MainMenu.SetActive(true);
            MainMenuTool.SetActive(true);
            MainExitController.SetActive(true);
            A.SetActive(true);
            CurrentBack.SetActive(false);
        }
    }
}
