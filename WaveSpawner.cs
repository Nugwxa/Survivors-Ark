using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
        public string name; 
        public Transform enemy;
        public int count;
        public float rate;
    }

    public PlayerHealth playerHealth;         // "PlayerHealth" script;
    public Text WaveText;
    public Text WaveText2;
    int WaveNumber;
    public Animator WaveAnim;
    public int HealthIncrease = 10;            // Health Boost
    public Transform[] grenadePoints;
    public int NumberOfBombs = 4;
    public GameObject Bomb1;
    public GameObject Bomb2;
    public GameObject Bomb3;
    public GameObject Bomb4;
    public GameObject Grenade;

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints; 

    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        WaveNumber = 1;

        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No Spawn Points Refferencd");
        } 

        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {
        WaveText.text = "Wave " + WaveNumber;
        WaveText2.text = "" + WaveNumber;

        if (playerHealth.currentHealth > 100)
        {
            playerHealth.currentHealth = 100;
            playerHealth.healthSlider.value = playerHealth.currentHealth;
        }

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

        if (Input.GetKeyDown(KeyCode.C) && NumberOfBombs > 0)
            {
                SpawnGrenade();

            }
        

            
        

        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void SpawnGrenade()
    {

        if (playerHealth.currentHealth < 100)
        {
            playerHealth.currentHealth = playerHealth.currentHealth + HealthIncrease;
            playerHealth.healthSlider.value = playerHealth.currentHealth;

            NumberOfBombs = NumberOfBombs - 1;
            return;
        }

        if (playerHealth.currentHealth <= 0)
        {
            return;
        }


        
        


        //Transform Gp = grenadePoints[Random.Range(0, grenadePoints.Length)];

        //Instantiate(Grenade, Gp.position, Gp.rotation);
    }

    void WaveCompleted()
    {
       WaveNumber = WaveNumber + 1;
        WaveAnim.SetTrigger("WaveComplete");

        if (WaveNumber % 10 == 0)
        {
            if (NumberOfBombs < 4)
            {
                NumberOfBombs = NumberOfBombs + 1;
            }

            

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

        Debug.Log("Wave Completed");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("Completed All Waves! Looping");
        }
        else
        {
            nextWave++;
        }         
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds( 1f/_wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("Spawning Enemy: " + _enemy.name);

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }
    
}
