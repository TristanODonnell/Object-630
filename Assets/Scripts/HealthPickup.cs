using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class HealthPickup : PickUp
{
    [SerializeField] private int amountOfHealth;
    public override void PickMe(Character character)
    { 
        if (character is Player)
        {
            
            base.PickMe(character);
        }    
                
    }

}