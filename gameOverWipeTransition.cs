using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverWipeTransition : MonoBehaviour
{

    public Animator transition;
    public float TransitionTime = 4;
    public int levelIndex;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit"))
        {
            ReloadLevel();
        }     
    }

    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(levelIndex));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("SlideIn");

        //Debug.Log("WE GOOD");

        yield return new WaitForSeconds(TransitionTime);

        SceneManager.LoadScene(levelIndex);


    }
}
