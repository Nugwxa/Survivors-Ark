using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public int damagePerShot = 10;

    float timer;
    int shootableMask;

    public Camera fpsCam;
    public CameraShake cameraShake;

    void Awake()
    {
        shootableMask = LayerMask.GetMask("Shootable");        
    }

    private float nextTimeToFire = 0f;

        // Update is called once per frame
        void Update () {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            StartCoroutine(cameraShake.Shake(.15f, 1.1f));

        }
		
	}

    void Shoot()
    {
        RaycastHit hit;
       if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, shootableMask))
        {
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage (damagePerShot, hit.point);
                
            }
            Debug.Log(hit.transform.name);
        }
    }
}
