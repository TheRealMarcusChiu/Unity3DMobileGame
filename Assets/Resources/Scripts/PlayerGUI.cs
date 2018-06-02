using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using System;

public class PlayerGUI : MonoBehaviour
{
    Player player;

	void Start ()
    {
        player = gameObject.GetComponent<Player>();
	}
	
	void Update ()
    {
        //Orient Camera based on Gyro Sensors
        Quaternion q = new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w);
        player.setCameraOrientation(q);

        //Move player based on joystick
        float degree = player.getCameraOrientation().eulerAngles.y;
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * player.speed, 0, CrossPlatformInputManager.GetAxis("Vertical") * player.speed);
        moveVec = Quaternion.Euler(0, degree, 0) * moveVec;
        player.move(moveVec);

        // fire if fire-button pressed
        if (CrossPlatformInputManager.GetButton("Fire")) player.fire();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 150, 10, 150, 150), "NEXT"))
            player.nextWeapon();
    }
}
