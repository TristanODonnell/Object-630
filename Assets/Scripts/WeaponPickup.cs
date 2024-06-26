using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : PickUp
{
    [SerializeField] private Weapon newWeapon;

    public override void PickMe(Character character)
    {
        character.ChangeWeapon(newWeapon);
        if ( character is Player)
        {
            character.ChangeWeapon(newWeapon);
            base.PickMe(character);
        }
        
    }
}
