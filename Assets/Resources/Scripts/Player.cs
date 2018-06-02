using UnityEngine;
using System.Collections;
using System;

public class Player : Damagable
{

    public float speed;
    public GameObject cam;

    private Score score;
    private WeaponController weaponController;
    private CharacterController cc;

    GUIStyle style;

    void Start ()
    {
        style = new GUIStyle("label");
        style.fontSize = 20;
        GUI.color = Color.black;

        cc = GetComponent<CharacterController>();

        score = GetComponent<Score>();
        weaponController = transform.GetChild(1).gameObject.GetComponent<WeaponController>();
	}

    public void fire()
    {
        weaponController.fireCurrentWeapon(cam.transform.position, cam.transform.rotation, gameObject);
    }

    public void move(Vector3 moveVec)
    {
        cc.SimpleMove(moveVec);
    }

    public void setCameraOrientation(Quaternion q)
    {
        cam.transform.localRotation = q;
    }

    public Quaternion getCameraOrientation()
    {
        return cam.transform.rotation;
    }

    public void nextWeapon()
    {
        weaponController.nextWeapon();
    }

    public void addScore(int i)
    {
        score.addScore(i);
    }

    public override void die()
    {
        GameController.gameOver();
    }

    public void reset()
    {
        health = 300;
        weaponController.reset();
    }
}
