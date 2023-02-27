using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public GameObject Credit;
    public GameObject Page1;
    Animator anim;

    public IEnumerator Start()
    {

        anim = GetComponent<Animator>();


        yield return new WaitForSeconds(5.5f);

        anim.SetTrigger("TimeIsReached");
        Page1.SetActive(false);
        
        Debug.Log("hellopage2");
        yield return new WaitForSeconds(5.5f);
        anim.SetTrigger("Animationfinished");
        Debug.Log("hello101");
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadSceneAsync(3);
        Credit.SetActive(false);
        Page1.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Start"))
        {
            Debug.Log("its working");
 
        }

    }

    public void Creditor()
    {
        SceneManager.LoadScene(4);
    }
}
