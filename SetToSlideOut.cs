using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetToSlideOut : MonoBehaviour
{
    public Animator Slide;
    public float TransitionTime2 = 2f;


    // Start is called before the first frame update
    void Start()
    {
        Slide.SetTrigger("SlideOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
