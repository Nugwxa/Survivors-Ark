using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform player;                    // Player's Location;          
    PlayerHealth playerHealth;           // "PlayerHealth" script;
    EnemyHealth enemyHealth;             // "EnemyHealth" script;
    NavMeshAgent nav;


	void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;       // Get the player's locaation;
        playerHealth = player.GetComponent <PlayerHealth> ();                // Get the player's health;
        enemyHealth = GetComponent <EnemyHealth> ();                         // Get the enemy's health;
        nav = GetComponent <NavMeshAgent> ();
	}
	

	void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)  // If the enemy & player are alive;
        {
        nav.SetDestination (player.position);                                // Chase player;
        }
        else
        {
         nav.enabled = false;                                                // Disable NavMesh
        }
    }
}
