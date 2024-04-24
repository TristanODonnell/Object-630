using UnityEngine;

public class Enemy :Character
{
    private Weapon weapon;
    private int touchDamage;
    [SerializeField] private float attackDistance;
    private Player player;
    private float timer;
    [SerializeField] private float shootCooldown = 3;
    protected override void Awake()
    {
        base.Awake();
        player =FindAnyObjectByType<Player>();
        timer = shootCooldown; 
    }
    

    public void SetupEnemy(int health, float speed, int damage)
    {
        //this.speed = speed;

    }
    private void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        Vector2 directionToThePlayer = player.transform.position - transform.position;
        if(distance > attackDistance)
        {
            Mathf.Atan2(directionToThePlayer.y, directionToThePlayer.x);
            Move(directionToThePlayer.normalized, Mathf.Atan2(directionToThePlayer.y, directionToThePlayer.x) * Mathf.Rad2Deg );
        }
        else //means enemy is close to target 
        {

            //damage the player
            timer += Time.deltaTime;
            if (timer >= shootCooldown)
            {

                Shoot(); //every 2 seconds 
                timer = 0;
            }
           // rigidBody.velocity = Vector2.zero;
        }
    }

    
    public override void Shoot()
    {
        //player.GetDamage(1);
        
        

    }
    public override void Move(UnityEngine.Vector2 direction, float angleToTurn)
    {
        base.Move(direction, angleToTurn);
    }

    public void Move()
    {
       
    }
    
    protected override void Die ()

    {
        base.Die();
       
       // GameManager.singleton.AddScore();
    }

  
    public Enemy(float speedParam, int touchDamage, int healthPoints)
    {
        this.healthPoints = new Health(healthPoints);
        speed = speedParam;
        this.touchDamage = touchDamage;
    }
}
