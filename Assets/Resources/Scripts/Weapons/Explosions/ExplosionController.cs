using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosionJustSmokeStreak;

    public void createJustExplosion(Vector3 position, bool withFireStreak)
    {
        if(withFireStreak)
            Instantiate(explosion, position, Quaternion.identity);
        else
            Instantiate(explosionJustSmokeStreak, position, Quaternion.identity);
    }

    public void createExplosionWithPhysics(Vector3 position, float explosionForce, float explosionRadius, int maxDamage, bool withFireStreak)
    {
        explosionPhysicsAndDamage(position, explosionForce, explosionRadius, maxDamage);

        createJustExplosion(position, withFireStreak);
    }

    static void explosionPhysicsAndDamage(Vector3 position, float explosionForce, float explosionRadius, int maxDamage)
    {
        Collider[] colliders = Physics.OverlapSphere(position, explosionRadius);

        foreach (Collider c in colliders)
        {
            if (c.GetComponent<Rigidbody>() == null) continue;

            c.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, position, explosionRadius, 0.5f, ForceMode.Impulse);

            if (c.gameObject.tag == "Enemy")
            {
                c.gameObject.GetComponent<Enemy>().decreaseHealth(maxDamage);
            }
        }
    }
}
