using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] protected int damage;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float range;
    [SerializeField] protected float fireRate;

    public virtual void shoot()
    {

    }
    public virtual void Shoot(Vector2 spawnPos, Quaternion aim)
    {
        //needs position (prob from player)
        //direction that the player is looking 
        Bullet b = GameObject.Instantiate(bulletPrefab, spawnPos, aim);
        b.SetupBullet(damage, bulletSpeed, "enemy");

        //instantiate new bullet



    }
    public virtual void StopShooting()
    {
        Debug.Log("Weapon stopped shooting");
    }

}
