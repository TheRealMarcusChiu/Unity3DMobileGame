using UnityEngine;
using System.Collections;

public abstract class Damagable : MonoBehaviour
{
    public int health;

    public void increaseHealth(int i)
    {
        health += i;
    }

    public void decreaseHealth(int i)
    {
        health -= i;
        if (health <= 0) die();
    }

    public abstract void die();
}
