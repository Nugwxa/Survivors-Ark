using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public Animator Transition;
    public Animator Slide;
    public float TransitionTime = 2f;
    public GameObject pauseMenuUI;
    public GameObject controlMenuUI;
    public GameObject PauseMenuUISystem;
    public GameObject player;
    public GameObject hudCanvas;
    public string RestartLevelName;

    public UserInput playerMovement;
    public EnemyAttack enemyAttack;
    public EnemyMovement enemyMovement;

    public EnemyAttack enemyAttack2;
    public EnemyMovement enemyMovement2;

    public EnemyAttack enemyAttack3;
    public EnemyMovement enemyMovement3;

    public EnemyAttack enemyAttack4;
    public EnemyMovement enemyMovement4;

    public EnemyAttack enemyAttack5;
    public EnemyMovement enemyMovement5;

    public EnemyAttack enemyAttack6;
    public EnemyMovement enemyMovement6;

    public EnemyAttack enemyAttack7;
    public EnemyMovement enemyMovement7;

    public EnemyAttack enemyAttack8;
    public EnemyMovement enemyMovement8;

    public EnemyAttack enemyAttack9;
    public EnemyMovement enemyMovement9;

    public EnemyAttack enemyAttack10;
    public EnemyMovement enemyMovement10;

    public EnemyAttack enemyAttack11;
    public EnemyMovement enemyMovement11;

    public EnemyAttack enemyAttack12;
    public EnemyMovement enemyMovement12;

    public EnemyAttack enemyAttack13;
    public EnemyMovement enemyMovement13;

    public EnemyAttack enemyAttack14;
    public EnemyMovement enemyMovement14;

    public EnemyAttack enemyAttack15;
    public EnemyMovement enemyMovement15;

    public PlayerHealth PlayerHealth;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
        playerMovement.enabled = true;
        enemyMovement.enabled = true;
        enemyAttack.enabled = true;
        enemyAttack.enabled = true;
        enemyMovement2.enabled = true;
        enemyAttack2.enabled = true;
        enemyMovement3.enabled = true;
        enemyAttack3.enabled = true;
        enemyMovement4.enabled = true;
        enemyAttack4.enabled = true;
        enemyMovement5.enabled = true;
        enemyAttack5.enabled = true;
        enemyMovement6.enabled = true;
        enemyAttack6.enabled = true;
        enemyMovement7.enabled = true;
        enemyAttack7.enabled = true;
        enemyMovement8.enabled = true;
        enemyAttack8.enabled = true;
        enemyMovement9.enabled = true;
        enemyAttack9.enabled = true;
        enemyMovement10.enabled = true;
        enemyAttack10.enabled = true;
        enemyMovement11.enabled = true;
        enemyAttack11.enabled = true;
        enemyMovement12.enabled = true;
        enemyAttack12.enabled = true;
        enemyMovement13.enabled = true;
        enemyAttack13.enabled = true;
        enemyMovement14.enabled = true;
        enemyAttack14.enabled = true;
        enemyMovement15.enabled = true;
        enemyAttack15.enabled = true;
        Time.timeScale = 1f;
    }


    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }


    }


    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        controlMenuUI.SetActive(false);
        PauseMenuUISystem.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        player.SetActive(true);
        PlayerHealth.enabled = true;
        hudCanvas.SetActive(true);
        playerMovement.enabled = true;
        enemyMovement.enabled = true;
        enemyAttack.enabled = true;
        enemyMovement2.enabled = true;
        enemyAttack2.enabled = true;
        enemyMovement3.enabled = true;
        enemyAttack3.enabled = true;
        enemyMovement4.enabled = true;
        enemyAttack4.enabled = true;
        enemyMovement5.enabled = true;
        enemyAttack5.enabled = true;
        enemyMovement6.enabled = true;
        enemyAttack6.enabled = true;
        enemyMovement7.enabled = true;
        enemyAttack7.enabled = true;
        enemyMovement8.enabled = true;
        enemyAttack8.enabled = true;
        enemyMovement9.enabled = true;
        enemyAttack9.enabled = true;
        enemyMovement10.enabled = true;
        enemyAttack10.enabled = true;
        enemyMovement11.enabled = true;
        enemyAttack11.enabled = true;
        enemyMovement12.enabled = true;
        enemyAttack12.enabled = true;
        enemyMovement13.enabled = true;
        enemyAttack13.enabled = true;
        enemyMovement14.enabled = true;
        enemyAttack14.enabled = true;
        enemyMovement15.enabled = true;
        enemyAttack15.enabled = true;
    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        controlMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.SetActive(false);
        PlayerHealth.enabled = false;
        hudCanvas.SetActive(false);
        playerMovement.enabled = false;
        enemyMovement.enabled = false;
        enemyAttack.enabled = false;
        enemyMovement2.enabled = false;
        enemyAttack2.enabled = false;
        enemyMovement3.enabled = false;
        enemyAttack3.enabled = false;
        enemyMovement4.enabled = false;
        enemyAttack4.enabled = false;
        enemyMovement5.enabled = false;
        enemyAttack5.enabled = false;
        enemyMovement6.enabled = false;
        enemyAttack6.enabled = false;
        enemyMovement7.enabled = false;
        enemyAttack7.enabled = false;
        enemyMovement8.enabled = false;
        enemyAttack8.enabled = false;
        enemyMovement9.enabled = false;
        enemyAttack9.enabled = false;
        enemyMovement10.enabled = false;
        enemyAttack10.enabled = false;
        enemyMovement11.enabled = false;
        enemyAttack11.enabled = false;
        enemyMovement12.enabled = false;
        enemyAttack12.enabled = false;
        enemyMovement13.enabled = false;
        enemyAttack13.enabled = false;
        enemyMovement14.enabled = false;
        enemyAttack14.enabled = false;
        enemyMovement15.enabled = false;
        enemyAttack15.enabled = false;
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {

        PlayerHealth.currentHealth = PlayerHealth.currentHealth + 99934;

        PlayerHealth.healthSlider.value = PlayerHealth.currentHealth;

        player.SetActive(false);
        PlayerHealth.enabled = false;
        hudCanvas.SetActive(false);
        playerMovement.enabled = false;
        enemyMovement.enabled = false;
        enemyAttack.enabled = false;
        enemyMovement2.enabled = false;
        enemyAttack2.enabled = false;
        enemyMovement3.enabled = false;
        enemyAttack3.enabled = false;
        enemyMovement4.enabled = false;
        enemyAttack4.enabled = false;
        enemyMovement5.enabled = false;
        enemyAttack5.enabled = false;
        enemyMovement6.enabled = false;
        enemyAttack6.enabled = false;
        enemyMovement7.enabled = false;
        enemyAttack7.enabled = false;
        enemyMovement8.enabled = false;
        enemyAttack8.enabled = false;
        enemyMovement9.enabled = false;
        enemyAttack9.enabled = false;
        enemyMovement10.enabled = false;
        enemyAttack10.enabled = false;
        enemyMovement11.enabled = false;
        enemyAttack11.enabled = false;
        enemyMovement12.enabled = false;
        enemyAttack12.enabled = false;
        enemyMovement13.enabled = false;
        enemyAttack13.enabled = false;
        enemyMovement14.enabled = false;
        enemyAttack14.enabled = false;
        enemyMovement15.enabled = false;
        enemyAttack15.enabled = false;

        Time.timeScale = 1f;
        


        Transition.SetTrigger("Start");
        Destroy(player);
        Debug.Log("WE GOOD");

        yield return new WaitForSeconds(TransitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }

    public void LoadLevelSlideIn(int sceneIndex)
    {
        StartCoroutine(SlideIn(sceneIndex));

    }

    IEnumerator SlideIn(int sceneIndex)
    {

        PlayerHealth.currentHealth = PlayerHealth.currentHealth + 99934;

        PlayerHealth.healthSlider.value = PlayerHealth.currentHealth;

        player.SetActive(false);
        PlayerHealth.enabled = false;
        hudCanvas.SetActive(false);
        playerMovement.enabled = false;
        enemyMovement.enabled = false;
        enemyAttack.enabled = false;
        enemyMovement2.enabled = false;
        enemyAttack2.enabled = false;
        enemyMovement3.enabled = false;
        enemyAttack3.enabled = false;
        enemyMovement4.enabled = false;
        enemyAttack4.enabled = false;
        enemyMovement5.enabled = false;
        enemyAttack5.enabled = false;
        enemyMovement6.enabled = false;
        enemyAttack6.enabled = false;
        enemyMovement7.enabled = false;
        enemyAttack7.enabled = false;
        enemyMovement8.enabled = false;
        enemyAttack8.enabled = false;
        enemyMovement9.enabled = false;
        enemyAttack9.enabled = false;
        enemyMovement10.enabled = false;
        enemyAttack10.enabled = false;
        enemyMovement11.enabled = false;
        enemyAttack11.enabled = false;
        enemyMovement12.enabled = false;
        enemyAttack12.enabled = false;
        enemyMovement13.enabled = false;
        enemyAttack13.enabled = false;
        enemyMovement14.enabled = false;
        enemyAttack14.enabled = false;
        enemyMovement15.enabled = false;
        enemyAttack15.enabled = false;

        Time.timeScale = 1f;

        Slide.SetTrigger("SlideIn");

        yield return new WaitForSeconds(TransitionTime);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);


    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application is quitting!");
    }

    
}
