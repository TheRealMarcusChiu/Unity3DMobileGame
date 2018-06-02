using UnityEngine;
using System.Collections;

public class MachineGunWeapon : Weapon
{
    public GameObject projectile;
    public AudioClip shot;
    public AudioClip emptyShot;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>() as AudioSource;
    }

    public override void fire(Vector3 firePosition, Quaternion q, GameObject go)
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + timeBetweenShots;

            if (numAmmo > 0)
            {
                //shoot bullet
                Handheld.Vibrate();
                audioSource.PlayOneShot(shot, 0.7F);
                numAmmo--;

                GameObject clone = (GameObject)Instantiate(projectile, firePosition, q);
                float force = clone.GetComponent<Bullet>().speed;
                clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * force);

                clone.GetComponent<Bullet>().shotFrom = go;
            }
            else
            {
                //shoot blanks
                audioSource.PlayOneShot(emptyShot, 0.7F);
            }
        }
        else
        {
        }
    }
}
