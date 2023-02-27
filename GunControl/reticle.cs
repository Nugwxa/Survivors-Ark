using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class reticle : MonoBehaviour{

    
    private RectTransform reticle;   // The RectTransform component of the game object this script is attached to

    
    [Range (50f, 250f)]     // Limit the value of the "size" variable to a range between 50 and 250
    public float size;      // The size of the reticle, which can be set in the Unity editor

    // Called at the start of the game
    private void Start(){

        // Get the RectTransform component from the game object
        reticle = GetComponent<RectTransform>();

    }

    // Called every frame
    void Update(){

        // Set the size of the reticle using the "sizeDelta" property of the RectTransform component
        reticle.sizeDelta = new Vector2(size, size);

    }
}
