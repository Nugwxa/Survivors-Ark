// Damage, range, and fire rate for the gun
public float damage = 10f;
public float range = 100f;
public float fireRate = 15f;

// Damage per shot and timer for the gun
public int damagePerShot = 10;
float timer;

// Layer mask for objects that can be shot
int shootableMask;

// Camera for the first-person view and camera shake effect
public Camera fpsCam;
public CameraShake cameraShake;

void Awake()
{
    // Set up shootable layer mask
    shootableMask = LayerMask.GetMask("Shootable");        
}

private float nextTimeToFire = 0f;

// Update is called once per frame
void Update () {

    // If the fire button is pressed and enough time has passed since the last shot, shoot and shake the camera
    if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
    {
        nextTimeToFire = Time.time + 1f / fireRate;
        Shoot();
        StartCoroutine(cameraShake.Shake(.15f, 1.1f));
    }
	
}

// Shoot a raycast from the camera's position in the direction it's facing
void Shoot()
{
    RaycastHit hit;
   if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, shootableMask))
    {
        // If the raycast hits an object with an EnemyHealth component, damage it
        EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage (damagePerShot, hit.point);
        }
        // Log the name of the object that was hit
        Debug.Log(hit.transform.name);
    }
}
