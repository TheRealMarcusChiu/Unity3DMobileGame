using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour
{
    public int originalNumAmmo;
    public int numAmmo;
    public float timeBetweenShots;
    protected float nextFire;

    public abstract void fire(Vector3 firePosition, Quaternion q, GameObject go);

    public void addAmmo(int i)
    {
        numAmmo += i;
    }

    public void setAmmo(int i)
    {
        numAmmo = i;
    }

    public int getNumAmmo()
    {
        return numAmmo;
    }

    public void setTimeBetweenShots(float i)
    {
        timeBetweenShots = i;
    }

    public float getTimeBetweenShots()
    {
        return timeBetweenShots;
    }

    public void reset()
    {
        numAmmo = originalNumAmmo;
    }
}
