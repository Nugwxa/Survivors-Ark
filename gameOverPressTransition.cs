using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverPressTransition : MonoBehaviour
{

    public Animator transition;
    public float TransitionTime = 4;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit"))                         // If player presses enter;
        {
            ReloadLevel();                                     // Restart level
        }     
    }

    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(7));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");                        // Trigger animation;

        //Debug.Log("WE GOOD");

        yield return new WaitForSeconds(TransitionTime);       // Wait for animation to finish playing;

        SceneManager.LoadScene(levelIndex);                    // Restart level;


    }
}
