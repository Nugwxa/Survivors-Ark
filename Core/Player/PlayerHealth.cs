using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                              // Player's starting health;
    public int currentHealth;                                     // Player's current health;
    public Slider healthSlider;                                   // Player's health UI;
    public Image damageImage;                                     // image to indicate when the player has been hit;
    public UserInput userInput;                                   // "UserInput" script;
    public AudioClip deathClip;                                   // Sound that plays when the player dies;
    public float flashSpeed = 5f;                                 // Speed at which damage image is shown;
    public Color flashColour = new Color(2f, 0f, 0f, 0.1f);       // Damage image color;

    public GameObject pauseMenu;                                  // Pause menu UI;
    public GameObject gameController;                             // Game controller script;


    Animator anim;
    AudioSource playerAudio;
    UserInput playerMovement;
    bool isDead;
    bool damaged;


	void Awake ()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<UserInput>();
        currentHealth = startingHealth;                           // Set the player's health to full at the start of the game;
	}
	

	void Update ()
    {
        if (damaged)                                               // If player is touched;
        {
            damageImage.color = flashColour;                       // Flash red;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime); // Clear screen;
        }
        damaged = false;
	}


    public void TakeDamage (int amount)            // For when the player is touched;
    {
        damaged = true;                            // Trigger Damage Image;

        currentHealth -= amount;                   // Remove damage amount from current health;

        healthSlider.value = currentHealth;        // Update the health UI to display the player's current health;

        playerAudio.Play();                        // Play hurt clip;

        if(currentHealth <= 0 && !isDead)          // If the player dies
        {
            Death();                               // Trigger death sequence
        }
    }


    void Death ()
    {
        isDead = true;

        //playerShooting.DisableEffects ();

        anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();
        pauseMenu.SetActive(false);
        gameController.SetActive(false);

        playerMovement.enabled = false;
        userInput.enabled = false;
    }
}
