using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{

    public GameObject Space;
    public GameObject Loading;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            Space.SetActive(false);
            Loading.SetActive(true);
            Debug.Log("it worked");
            SceneManager.LoadSceneAsync("Menu");
        }
            

    }
}
