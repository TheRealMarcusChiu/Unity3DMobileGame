using UnityEngine;
using System.Collections;

public abstract class Projectile : MonoBehaviour
{
    public float speed;
    public float countdown;
    public int damage;
    public GameObject shotFrom;

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            DestroyItself();
    }

    // find out when it hit something
    public abstract void OnCollisionEnter(Collision c);
    public abstract void DestroyItself();
}
