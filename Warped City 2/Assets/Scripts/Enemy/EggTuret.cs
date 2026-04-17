using UnityEngine;

public class EggTuret : MonoBehaviour
{
    [Header("Shooting Settings")]
    [SerializeField] private float shootingRange = 10f;
    [SerializeField] private float bulletForce = 10f;

    [Header("References")]
    [SerializeField] private Transform player;
    [SerializeField] private Transform firePoint;
    [SerializeField] private ObjectPooler pooler;

    [Header("Bullet Settings")]
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private float nextTimeRate;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        pooler = FindAnyObjectByType<ObjectPooler>();
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if(distanceFromPlayer <= shootingRange && nextTimeRate < Time.time)
        {
            Shoot();
            nextTimeRate = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = pooler.SpawnFromPools("EnemyBullet", firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(-transform.right * bulletForce, ForceMode2D.Impulse);
    }
}