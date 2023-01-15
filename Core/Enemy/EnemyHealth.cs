using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;          // Enemy's starting health;
    public int currentHealth;                 // Enemy's current health;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;               // Points for killing enemy;
    public GameObject Particle;               // Death particle effect;
    public GameObject StartParticle;          // Spawn particle effect;
    public GameObject enemyIcon;
    public GameObject minimapEnemyIcon;
    public AudioClip deathClip;


    Animator anim;
    AudioSource enemyAudio;

    CapsuleCollider capsuleCollider;
    bool isDead;
    bool isSinking;


	void Awake ()
    {
        StartParticle.SetActive(true);                // Play particle effect;
        anim = GetComponent <Animator> ();
        enemyAudio = GetComponent <AudioSource> ();

        capsuleCollider = GetComponent <CapsuleCollider> ();

        currentHealth = startingHealth;               // Set health to starting health(100);
	}
	
	
	void Update ()
    {
		if(isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);  // Send eneny below the terrain;
        }
	}


    public void TakeTotalDamage(int amount)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;  // Take damage amount from health;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void TakeDamage (int amount, Vector3 hitPoint)
    {
        if (isDead)
            return;

        enemyAudio.Play();

        currentHealth -= amount;

        


        if(currentHealth <= 0)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        anim.SetTrigger("Dead");
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;

        ScoreManagerLevel001.score += scoreValue;
        ScoreManagerLevel002.score += scoreValue;
        ScoreManager.score += scoreValue;               // Add points;
        enemyIcon.SetActive(false);
        minimapEnemyIcon.SetActive(true);
        enemyAudio.clip = deathClip;
        enemyAudio.Play();                              // Play enemy death clip
    }


    public void StartSinking ()
    {
              
        isSinking = true;               // Start sinking sequence;
        Particle.SetActive(true);       // Play particle effect;
        Destroy(gameObject, 2f);        // Destroy enemy after 2 secends;
    }
}
