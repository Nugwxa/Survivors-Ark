using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerLevel002 : MonoBehaviour
{
    public float restartDelay = 5f;
    public static int score;
    public int target;
    public int TargetLevel;
    public GameObject MissionCanvas;
    public GameObject LevelCleared;
    public EnemyAttack Attar;
    public CharacterMovement playerMovement;

       
    
    Animator anim;
    Text text;
    float restartTimer;

    void Awake ()
    {
        anim = GetComponent<Animator>();
        text = GetComponent<Text> ();
        score = 50;
	}
	

	void Update ()
    {
        text.text = ""+ score;

        if (score < target)
        {

            playerMovement.enabled = false;
            Attar.enabled = false;
            MissionCanvas.SetActive(false);

            
            LevelCleared.SetActive(true);

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadSceneAsync(TargetLevel);
            }

            Debug.Log("burna");
        }
	}
}
