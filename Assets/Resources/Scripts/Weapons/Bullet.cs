using UnityEngine;
using System.Collections;
using System;

public class Bullet : Projectile
{
    public override void OnCollisionEnter(Collision c)
    {
        if(shotFrom != c.gameObject)
        {
            if (c.gameObject.GetComponent<Damagable>() != null)
            {
                c.gameObject.GetComponent<Damagable>().decreaseHealth(damage);
            }

            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }       
    }

    public override void DestroyItself()
    {
        Destroy(gameObject);
    }
}
