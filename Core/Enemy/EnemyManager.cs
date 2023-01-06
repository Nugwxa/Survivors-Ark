using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;         // "PlayerHealth" script;
    public GameObject enemy;                  // Enemy to be spawned (Prefab);
    public float spawnTime = 0.5f;            // Time between each spawn;
    public Transform[] spawnPoints;           // Spawnpoints;


	void Start ()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);                 // Spawn enemies;
	}
	
	
	void Spawn ()
    {
		if(playerHealth.currentHealth <= 0f)                    // If player is dead don't spawn;
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);      // Spawn Randomly

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
