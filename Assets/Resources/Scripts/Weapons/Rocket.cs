using UnityEngine;
using System.Collections;
using System;

public class Rocket : Projectile
{
    public float force;
    public float radius;

    public override void OnCollisionEnter(Collision c)
    {
        if(shotFrom != c.gameObject)
        {
            if(c.gameObject.GetComponent<Damagable>() != null)
            {
                c.gameObject.GetComponent<Damagable>().decreaseHealth(damage);
            }

            DestroyItself();
        }
    }

    public override void DestroyItself()
    {
        GameController.explosionController.createExplosionWithPhysics(transform.position, force, radius, damage/2, true);
        Destroy(gameObject);
    }
}
