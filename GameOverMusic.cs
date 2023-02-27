using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMusic : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject Over;
    public float restartDelay = 2f;
    float restartTimer;


	void Awake()
    {
        
	}
	

	void Update ()
    {
        if (playerHealth.currentHealth <= 0)
        {
            


            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                Over.SetActive(true);
            }
        }
	}
}
