using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeControl : MonoBehaviour
{

    public GameObject GrenadeObject;      // Physical Grenade;
    public GameObject ExplosionParticle;  // Explosion Effect;
    public GameObject ExplosionSound;
    public GameObject DamageStuff;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);        // Once the grnade has been thrown, wait 3 seconds;
        Destroy(GrenadeObject);                     // Remove the grenade from the scene;
        ExplosionParticle.SetActive(true);          // Play explosion effect;
        ExplosionSound.SetActive(true);             // Play explosion sound;
        DamageStuff.SetActive(true);        
        yield return new WaitForSeconds(2f);        // Wait 2 seconds to allow the explosion effect and sound play;
        Destroy(gameObject);                        // Destroy the game object/script;
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
