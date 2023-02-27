using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModeLoader : MonoBehaviour
{

    public Animator Transition;
    public Animator Slide;
    public GameObject LoadingScreen;
    public Slider slider;
    public float TransitionTime = 5f;
    public float TransitionTime2 = 5f;


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    public void LoadLevelSlideIn(int sceneIndex)
    {
        StartCoroutine(SlideIn(sceneIndex));

    }

    public void LoadLevelSlideOut(int sceneIndex)
    {
        StartCoroutine(SlideOut(sceneIndex));

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        
        Transition.SetTrigger("Start");

        yield return new WaitForSeconds(TransitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }


    IEnumerator SlideIn(int sceneIndex)
    {

        Slide.SetTrigger("SlideIn");

        yield return new WaitForSeconds(TransitionTime2);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }

    IEnumerator SlideOut(int sceneIndex)
    {

        Slide.SetTrigger("SlideOut");

        yield return new WaitForSeconds(TransitionTime2);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }
}
