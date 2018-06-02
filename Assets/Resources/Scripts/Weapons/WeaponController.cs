using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{
    public int currentWeaponIndex;
    private Weapon currentWeaponScript;
    private GameObject weapons;
    private int numWeapons;
    private string weaponPrefabsPath = "Prefabs/Weapons/";

    // Use this for initialization
    void Start()
    {
        weapons = new GameObject();
        weapons.name = "weapons";
        weapons.transform.parent = transform;

        numWeapons = 0;

        addWeapon("BulletWeapon");
        addWeapon("MachineGunWeapon");
        addWeapon("RocketLauncherWeapon");

        currentWeaponScript = weapons.transform.GetChild(currentWeaponIndex).gameObject.GetComponent<Weapon>();
    }

    public void addWeapon(string s)
    {
        string path = weaponPrefabsPath + s;
        GameObject prefabClone = Instantiate(Resources.Load<GameObject>(path));
        prefabClone.transform.parent = weapons.transform;
        numWeapons++;
    }

    public bool switchWeapon(int i)
    {
        if(i >= 0 && i < numWeapons)
        {
            currentWeaponIndex = i;
            currentWeaponScript = weapons.transform.GetChild(currentWeaponIndex).gameObject.GetComponent<Weapon>();
            return true;
        }
        return false;      
    }

    public void nextWeapon()
    {
        currentWeaponIndex++;

        if (currentWeaponIndex >= numWeapons)
            currentWeaponIndex = 0;

        currentWeaponScript = weapons.transform.GetChild(currentWeaponIndex).gameObject.GetComponent<Weapon>();
    }

    public void fireCurrentWeapon(Vector3 firePosition, Quaternion q, GameObject go)
    {
        currentWeaponScript.fire(firePosition, q, go);
    }

    public void reset()
    {
        foreach(Transform t in weapons.transform)
        {
            t.gameObject.GetComponent<Weapon>().reset();
        }
    }
}
