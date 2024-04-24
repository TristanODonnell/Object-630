using Unity.VisualScripting;
using UnityEngine;

public class Player : Character
{

    [SerializeField] private Bullet bulletPrefab;
    protected override void Awake()
    {
        base.Awake();
       // weapon = new Weapon(bulletPrefab, 1, 8.5f);
    }
    
    protected override void Die()
    {
        base.Die();
        GameManager.singleton.StopGame();
        
    }
    public override void Move(Vector2 direction, float angleToRotate)
    {
        base.Move(direction, angleToRotate);
        Debug.Log("Moving Player with speed of" + speed.ToString());

    }

    
    public Player()
    {
        healthPoints = new Health(4);
       // weapon = new Weapon();

        speed = 5;
    }

    public Player(float speedParameter, int amountOfHealth) : base(speedParameter, amountOfHealth)
    { 
        //weapon = new Weapon();
    }
}
