using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverWipeTransition : MonoBehaviour
{
    
    public Animator transition;         // Animator component responsible for the transition animation
    public float TransitionTime = 4;    // Duration of the transition animation
    public int levelIndex;              // Index of the scene to load after the animation

    // Update is called once per frame
    void Update()
    {
        // Reload the level when the Submit button is pressed (e.g. Enter key)
        if (Input.GetButton("Submit"))
        {
            ReloadLevel();
        }     
    }

    // Method to start the level reloading coroutine
    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(levelIndex));
    }

    // Coroutine to perform the transition and load the next scene
    IEnumerator LoadLevel(int levelIndex)
    {
        // Start the "SlideIn" trigger of the transition animation
        transition.SetTrigger("SlideIn");

        // Wait for the transition animation to finish
        yield return new WaitForSeconds(TransitionTime);

        // Load the next scene with the specified index
        SceneManager.LoadScene(levelIndex);
    }
}
