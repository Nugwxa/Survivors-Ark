using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{


    public GameObject pickupEffect;
    public PlayerHealth playerHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp( Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        playerHealth.currentHealth = 50;

        Destroy(gameObject);
    }

}
