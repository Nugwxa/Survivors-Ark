using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasloader : MonoBehaviour
{
    // Declare a public GameObject variable called CanvasAnim
    // This will hold a reference to the canvas animation object
    public GameObject CanvasAnim;

    // Start is called before the first frame update
    void Start()
    {
    

        CanvasAnim.SetActive(true); // Activate the CanvasAnim GameObject to make it visible
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
