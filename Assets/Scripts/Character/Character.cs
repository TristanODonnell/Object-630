using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{
    protected Health healthPoints;
    [SerializeField] protected float speed;
    [SerializeField] protected Weapon weapon;
    
    
    protected Rigidbody2D rigidBody;

    protected virtual void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        healthPoints = new Health(5);
        healthPoints.OnLifeChanged.AddListener(Checklife);
       
    }

    void Checklife(int lifeValue)
    {
        if (lifeValue <= 0)
        {
            Die();
        }
    }
    public virtual void Move(Vector2 direction, float angleToRotate)
   {
        rigidBody.AddForce(direction * speed *Time.deltaTime *1000f);
     transform.rotation = Quaternion.Euler(0, 0, angleToRotate);   
        Debug.Log("character moving to " + direction);
   }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

    public Character()
    {

    }
    public Character(float speedParameter, int amountOfHealth)
    {
        speed = speedParameter;
        healthPoints = new Health(amountOfHealth);
    }

    public virtual void Shoot()
    {
        weapon.Shoot(transform.position, transform.rotation);
        Debug.Log("shooting a weapon");
    }

    public void GetDamage(int damage)
    {
        healthPoints.DecreaseHealth();
        
    }
    public Health GetHealthInformation()
    {
        return healthPoints;
    }

    public void ChangeWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
    }
}
