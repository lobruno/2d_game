using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public Transform firePoint;      // The point from which bullets will be fired
    public GameObject bulletPrefab;  // The bullet prefab
    public float bulletSpeed = 10f; // The bullet's speed
    public float fireRate = 0.5f;    // Fire rate (bullets per second)
    private float nextFireTime;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        // Check if it's possible to shoot
        if (Time.time > nextFireTime)
        {
            if (Input.GetMouseButton(0) && playerMovement.canAttack()) // Shoot
            {
                Shoot();
                nextFireTime = Time.time + 1 / fireRate; // Update the time for the next shot
            }
        }
    }

    void Shoot()
    {
        anim.SetTrigger("attack");
        // Create an instance of the bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bull = bullet.GetComponent<Bullet>();
        bull.SetDirection(Mathf.Sign(transform.localScale.x));
    }
}


