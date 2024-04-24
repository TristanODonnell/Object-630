using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {   

        Character picker = collision.attachedRigidbody.GetComponent<Character>();
        if (picker != null)
        {
            PickMe(picker);

        }
    }

    public virtual void PickMe(Character character)
    {

        Destroy(gameObject);
    }



}
