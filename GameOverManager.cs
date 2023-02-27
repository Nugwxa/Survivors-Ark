using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject pauseMenu;
    public float restartDelay = 4f;

    public UserInput playerMovement;


    Animator anim;
    float restartTimer;


	void Awake()
    {
        anim = GetComponent<Animator>();
	}
	

	void Update ()
    {
        if (playerHealth.currentHealth <= 0)
        {
            pauseMenu.SetActive(false);
            anim.SetTrigger("GameOver");
            playerMovement.enabled = false;





        }
	}
}
