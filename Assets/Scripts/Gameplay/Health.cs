using UnityEngine;
using UnityEngine.Events;
public class Health 
{
    private int healthPoints;
    public UnityEvent <int> OnLifeChanged;
    public UnityEvent onDie;

    public int DecreaseHealth()
    {

        return DecreaseHealth(1);
    }
    public int DecreaseHealth(int damage)
    {
        healthPoints--;
        OnLifeChanged.Invoke(healthPoints);
        if (healthPoints >= 0)
        {
            //invoke(onDie);
        }
        Debug.Log("decreasing health" + healthPoints);
        return healthPoints;
    }
    public int IncreaseHealth()
    {
        Debug.Log("increasing health");
        healthPoints++;
        return healthPoints;
    }
    public Health(int maxHealth)
    {
        healthPoints = maxHealth;
        OnLifeChanged = new UnityEvent<int>();
    }
}
