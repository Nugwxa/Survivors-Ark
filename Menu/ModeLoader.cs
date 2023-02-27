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

    // Coroutine method to load a scene with a transition animation
    public void LoadLevel(int sceneIndex)
    {
        // Start the LoadAsynchronously coroutine with the given scene index
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    // Coroutine method to load a scene with a slide-in animation
    public void LoadLevelSlideIn(int sceneIndex)
    {
        // Start the SlideIn coroutine with the given scene index
        StartCoroutine(SlideIn(sceneIndex));
    }

    // Coroutine method to load a scene with a slide-out animation
    public void LoadLevelSlideOut(int sceneIndex)
    {
        // Start the SlideOut coroutine with the given scene index
        StartCoroutine(SlideOut(sceneIndex));
    }

    // Coroutine method to load a scene asynchronously and play a transition animation
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        // Trigger the "Start" trigger of the Transition animator, which presumably plays a transition animation
        Transition.SetTrigger("Start");

        // Wait for a set duration of TransitionTime before loading the scene asynchronously
        yield return new WaitForSeconds(TransitionTime);

        // Load the scene asynchronously using the SceneManager.LoadSceneAsync method
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    }

    // Coroutine method to load a scene asynchronously and play a slide-in animation
    IEnumerator SlideIn(int sceneIndex)
    {
        // Trigger the "SlideIn" trigger of the Slide animator, which presumably plays a slide-in animation
        Slide.SetTrigger("SlideIn");

        // Wait for a set duration of TransitionTime2 before loading the scene asynchronously
        yield return new WaitForSeconds(TransitionTime2);

        // Load the scene asynchronously using the SceneManager.LoadSceneAsync method
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    }

    // Coroutine method to load a scene asynchronously and play a slide-out animation
    IEnumerator SlideOut(int sceneIndex)
    {
        // Trigger the "SlideOut" trigger of the Slide animator, which presumably plays a slide-out animation
        Slide.SetTrigger("SlideOut");

        // Wait for a set duration of TransitionTime2 before loading the scene asynchronously
        yield return new WaitForSeconds(TransitionTime2);

        // Load the scene asynchronously using the SceneManager.LoadSceneAsync method
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    }
}
