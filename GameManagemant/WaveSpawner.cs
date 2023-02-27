using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    // The possible states that the spawner can be in.
public enum SpawnState { SPAWNING, WAITING, COUNTING };

// the attributes of each wave.
[System.Serializable]
public class Wave
{
    public string name; 
    public Transform enemy;
    public int count;
    public float rate;
}

// various attributes that are accessed in the inspector.
public PlayerHealth playerHealth;         
public Text WaveText;
public Text WaveText2;
int WaveNumber;
public Animator WaveAnim;
public int HealthIncrease = 10;            
public Transform[] grenadePoints;
public int NumberOfBombs = 4;
public GameObject Bomb1;
public GameObject Bomb2;
public GameObject Bomb3;
public GameObject Bomb4;
public GameObject Grenade;

// Define the waves.
public Wave[] waves;
private int nextWave = 0;

// Define the spawn points and time intervals.
public Transform[] spawnPoints; 
public float timeBetweenWaves = 5f;
private float waveCountdown;

// Define the time interval between searches for enemies.
private float searchCountdown = 1f;

// Set the initial state of the spawner to "COUNTING".
private SpawnState state = SpawnState.COUNTING;

void Start()
{
    WaveNumber = 1;

    // If there are no spawn points defined, display an error message.
    if (spawnPoints.Length == 0)
    {
        Debug.LogError("No Spawn Points Referenced");
    } 

    // Set the initial wave countdown.
    waveCountdown = timeBetweenWaves;
}

void Update()
{
    // Update the text displaying the current wave number.
    WaveText.text = "Wave " + WaveNumber;
    WaveText2.text = "" + WaveNumber;

    // Ensure that the player's health never exceeds 100.
    if (playerHealth.currentHealth > 100)
    {
        playerHealth.currentHealth = 100;
        playerHealth.healthSlider.value = playerHealth.currentHealth;
    }

    // Update the display of the grenades based on how many are remaining.
    if (NumberOfBombs == 0)
    {
        Bomb1.SetActive(false);
        Bomb2.SetActive(false);
        Bomb3.SetActive(false);
        Bomb4.SetActive(false);
    }

    if (NumberOfBombs == 1)
    {
        Bomb1.SetActive(true);
        Bomb2.SetActive(false);
        Bomb3.SetActive(false);
        Bomb4.SetActive(false);
    }

    if (NumberOfBombs == 2)
    {
        Bomb1.SetActive(true);
        Bomb2.SetActive(true);
        Bomb3.SetActive(false);
        Bomb4.SetActive(false);
    }

    if (NumberOfBombs == 3)
    {
        Bomb1.SetActive(true);
        Bomb2.SetActive(true);
        Bomb3.SetActive(true);
        Bomb4.SetActive(false);
    }

    if (NumberOfBombs == 4)
    {
        Bomb1.SetActive(true);
        Bomb2.SetActive(true);
        Bomb3.SetActive(true);
        Bomb4.SetActive(true);
    }

    // If the player presses the "C" key and there are grenades remaining, 
    // spawn a grenade and reduce the number of grenades remaining.
        if (Input.GetKeyDown(KeyCode.C) && NumberOfBombs > 0)
            {
                SpawnGrenade();

            }
        

            
// Check if the spawn state is WAITING
if (state == SpawnState.WAITING)
{
    // If no enemies are alive, the wave is completed
    if (!EnemyIsAlive())
    {
        WaveCompleted();
    }
    else
    {
        // If enemies are still alive, return and wait for them to be defeated
        return;
    }
}

// If the wave countdown has reached 0
if (waveCountdown <= 0)
{
    // Check if the spawn state is not SPAWNING
    if (state != SpawnState.SPAWNING)
    {
        // Start spawning the next wave
        StartCoroutine(SpawnWave(waves[nextWave]));
    }
}
else
{
    // If the wave countdown hasn't reached 0 yet, decrement it
    waveCountdown -= Time.deltaTime;
}

// Spawn a grenade if the player's health is less than 100
void SpawnGrenade()
{
    if (playerHealth.currentHealth < 100)
    {
        // Increase the player's health by HealthIncrease and update the health slider
        playerHealth.currentHealth = playerHealth.currentHealth + HealthIncrease;
        playerHealth.healthSlider.value = playerHealth.currentHealth;

        // Decrement the number of bombs the player has left
        NumberOfBombs = NumberOfBombs - 1;
        return;
    }

    // If the player's health is 0 or less, do nothing
    if (playerHealth.currentHealth <= 0)
    {
        return;
    }
}
        
        


        //Transform Gp = grenadePoints[Random.Range(0, grenadePoints.Length)];

        //Instantiate(Grenade, Gp.position, Gp.rotation);
    }

    
    // This function is called when all enemies in the current wave are defeated
    void WaveCompleted()
    {
        
        // Increment the wave number and trigger the wave completed animation
       WaveNumber = WaveNumber + 1;
        WaveAnim.SetTrigger("WaveComplete");

        // Check if the wave number is a multiple of 10 and adjust the number of bombs available accordingly
        if (WaveNumber % 10 == 0)
        {
            // Increase the number of bombs available up to a maximum of 4
            if (NumberOfBombs < 4)
            {
                NumberOfBombs = NumberOfBombs + 1;
            }

            // Set the active bomb object(s) based on the number of bombs available
            if (NumberOfBombs == 0)
            {
                NumberOfBombs = NumberOfBombs + 1;
                Bomb1.SetActive(true);
                Bomb2.SetActive(false);
                Bomb3.SetActive(false);
                Bomb4.SetActive(false);
            }

            if (NumberOfBombs == 1)
            {
  
                NumberOfBombs = NumberOfBombs + 1;
                Bomb1.SetActive(true);
                Bomb2.SetActive(true);
                Bomb3.SetActive(false);
                Bomb4.SetActive(false);
            }

            if (NumberOfBombs == 2)
            {
                NumberOfBombs = NumberOfBombs + 1;
                Bomb1.SetActive(true);
                Bomb2.SetActive(true);
                Bomb3.SetActive(true);
                Bomb4.SetActive(false);
            }

            if (NumberOfBombs == 3)
            {
                NumberOfBombs = NumberOfBombs + 1;
                Bomb1.SetActive(true);
                Bomb2.SetActive(true);
                Bomb3.SetActive(true);
                Bomb4.SetActive(true);
            }
        }

        // Log a message to indicate that the wave is completed
        Debug.Log("Wave Completed");

        // Set the state to counting and reset the wave countdown timer
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        // If all waves have been completed, reset the next wave index to 0 and log a message to indicate that the game is looping
        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("Completed All Waves! Looping");
        }
        else
        {
            // Otherwise, increment the next wave index
            nextWave++;
        }         
         
    }

    // This function checks if enemies are still alive in the game
    bool EnemyIsAlive()
    {
        // Decrement the search countdown by Time.deltaTime
        searchCountdown -= Time.deltaTime;
        
        // If the search countdown has elapsed
        if (searchCountdown <= 0f)
        {
            // Reset the search countdown to 1 second
            searchCountdown = 1f;
            
            // Check if there are any game objects with the tag "Enemy"
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                
                // If there are no game objects with the tag "Enemy", return false
                return false;
            }
        }
        
        // Return true if there are still enemies alive
        return true;
    }

    // This function spawns a wave of enemies
    IEnumerator SpawnWave(Wave _wave)
    {
        // Log that a wave is being spawned
        Debug.Log("Spawning Wave: " + _wave.name);
        // Set the spawn state to SPAWNING
        state = SpawnState.SPAWNING;

        // Spawn the number of enemies specified in the wave
        for (int i = 0; i < _wave.count; i++)
        {
            // Spawn an enemy
            SpawnEnemy(_wave.enemy);
            // Wait for a duration based on the spawn rate
            yield return new WaitForSeconds( 1f/_wave.rate);
        }

        // Set the spawn state to WAITING
        state = SpawnState.WAITING;

        yield break;
    }

    // This function spawns an enemy
    void SpawnEnemy(Transform _enemy)
    {
        // Log that an enemy is being spawned
        Debug.Log("Spawning Enemy: " + _enemy.name);

        // Choose a random spawn point from the array of spawn points
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        // Instantiate the enemy at the chosen spawn point
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }

    
}
