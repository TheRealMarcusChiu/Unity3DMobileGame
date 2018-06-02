using UnityEngine;
using System.Collections;

public class acceleration : MonoBehaviour
{/*
    public GameObject go;
    float filter = 10.0f;
    Vector3 velocityVector;
    Vector3 accel;
    float deltaTime;

    bool userAccel = true;

    GUIStyle style;

    void Start()
    {
        style = new GUIStyle("label");
        style.fontSize = 20;
        GUI.color = Color.black;

        userAccel = true;
        velocityVector = new Vector3(0, 0, 0);
        accel = Input.gyro.userAcceleration;
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        //go.transform.Translate(0, 0, -Input.gyro.userAcceleration.z);
        //Vector3 forceVector = new Vector3(0, 0, value);
        //go.GetComponent<Rigidbody>().AddForce(-Input.gyro.userAcceleration.z * forceVector * value);
        if(userAccel)
        {
            deltaTime = Time.deltaTime;
            // filter the jerky acceleration in the variable accel: 
            //accel = Vector3.Lerp(accel, Input.gyro.userAcceleration, 0.5f);
            accel = Input.gyro.userAcceleration;
            //Vector3 newAccel = Input.gyro.userAcceleration;
            //Vector3 averageAccel = Vector3.Lerp(accel, newAccel, 0.5f);

            if (accel.magnitude > 0.02f)
            {
                // map accel -Y and X to game X and Y directions: 
                velocityVector += new Vector3((accel.x - value) * deltaTime, 0, 0);

                // move the object at the velocity defined in speed: 
                transform.Translate(velocityVector * deltaTime);
            }
        }
        else
        {
            // filter the jerky acceleration in the variable accel: 
            //accel = Vector3.Lerp(accel, Input.acceleration, filter * Time.deltaTime);
            accel = Input.acceleration;

            // map accel -Y and X to game X and Y directions: 
            Vector3 dir = new Vector3(accel.x, 0, 0);

            // limit dir vector to magnitude 1: 
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            // move the object at the velocity defined in speed: 
            transform.Translate(dir * value * Time.deltaTime);
        }
    }

    float value = 0.02f;

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 150, 10, 150, 150), "reset P"))
            go.transform.position = new Vector3(0, 0, 10);
        if(userAccel)
        {
            if (GUI.Button(new Rect(Screen.width - 300, 10, 150, 150), "go nonuser"))
            {
                //userAccel = false;
                //accel = Input.acceleration;
            }
        }
        else
        {
            if (GUI.Button(new Rect(Screen.width - 300, 10, 150, 150), "go user"))
            {
                userAccel = true;
                accel = Input.gyro.userAcceleration;
            }
        }
        if (GUI.Button(new Rect(Screen.width - 450, 10, 150, 150), "reset v"))
            velocityVector = new Vector3(0, 0, 0);
        if (GUI.Button(new Rect(Screen.width - 600, 10, 150, 150), "r sub_acell"))
            value = 0.0f;


        value = GUI.HorizontalSlider(new Rect(10, Screen.height - 50, Screen.width - 20, 500), value, -0.5F, 0.5F);
        string v_string = "sub accel x: " + value.ToString();
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, 300, 40), v_string, style);

        string a_string = "accel x value: " + accel.x.ToString();
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 70, 300, 40), a_string, style);

        //string dt_string = "deltaTime: " + deltaTime.ToString();
        //GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 120, 300, 40), dt_string, style);

        string vx_string = "velocity: " + velocityVector.x.ToString();
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 120, 300, 40), vx_string, style);
    }*/
}
