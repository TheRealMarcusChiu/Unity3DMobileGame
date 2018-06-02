using UnityEngine;
using System.Collections;
using System;

public class Enemy : Damagable
{
    NavMeshAgent agent;
    public int selfDestructDamage = 100;
    public float rangeToExplode = 5;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();	
	}
	
	void Update ()
    {
        Vector3 playerPosition = GameController.player.transform.position;
        agent.SetDestination(playerPosition);

        if((playerPosition - transform.position).magnitude <= rangeToExplode)
        {
            GameController.player.GetComponent<Player>().decreaseHealth(selfDestructDamage);
            die();
        }
	}

    public override void die()
    {
        GameController.explosionController.createJustExplosion(transform.position, false);
        Destroy(gameObject);
    }
}
