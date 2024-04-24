
using UnityEngine;
public class Bullet : MonoBehaviour
{ 

    protected float speed;
    protected int damage;
    protected string tagFilter;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }
    public void SetupBullet(int damageParam, float speedParam)
    {
        speed = speedParam;
        damage = damageParam;
    }

    public void SetupBullet(int damageParam, float speedParam, string tagFilter)
    {
        speed = speedParam;
        damage = damageParam;
        this.tagFilter = tagFilter;
    }
    public void MoveProjectile(float damage = 5)
    {
        //moving forward
    }

    public void MoveProjectile(Transform target)
    {
        //moves towards target 
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.CompareTag(tagFilter));
        {
            collision.attachedRigidbody.GetComponent<IDamageable>().GetDamage(damage);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }
}
