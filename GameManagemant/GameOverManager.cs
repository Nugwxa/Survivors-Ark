using UnityEngine; 
using UnityEngine.SceneManagement; 


public class GameOverManager : MonoBehaviour // define the GameOverManager class
{

    public PlayerHealth playerHealth; // reference to the PlayerHealth script
    public GameObject pauseMenu;      // reference to the pause menu game object
    public float restartDelay = 4f;   // delay before restarting the game
    public UserInput playerMovement;  // reference to the UserInput script

    Animator anim; // Animator component attached to this object
    float restartTimer; // timer for game restart

    void Awake() // function called when the script is loaded
    {
        anim = GetComponent<Animator>(); // get the Animator component
    }

    void Update() // function called once per frame
    {
        if (playerHealth.currentHealth <= 0) // check if the player's health is zero or below
        {
            pauseMenu.SetActive(false); // hide the pause menu
            anim.SetTrigger("GameOver"); // trigger the "GameOver" animation
            playerMovement.enabled = false; // disable the player's movement

            // game restart logic below
        }
    }
}
