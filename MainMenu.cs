using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	    public void PlayGame ()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayDungeon ()
    {
        SceneManager.LoadScene(7);
    }

    public void QuitGame ()
    {
        Debug.Log("Application is quitting!");
        Application.Quit();
    }
    //Loader
  
}
