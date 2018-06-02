using UnityEngine;
using System.Collections;

public class Gyro : MonoBehaviour
{
    private Quaternion q;
    private Vector3 gravity;
    private Vector3 acceleration;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        q = new Quaternion(-Input.gyro.attitude.x, -Input.gyro.attitude.y, Input.gyro.attitude.z, Input.gyro.attitude.w);
        gravity = Input.gyro.gravity;
        acceleration = Input.acceleration;
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle("label");
        style.fontSize = 20;
        GUI.color = Color.black;

        string q_string = "quaternion: " + q.eulerAngles.ToString();
        GUI.Label(new Rect(10, 10, 300, 40), q_string, style);

        string g_string = "gravity: " + gravity.ToString();
        GUI.Label(new Rect(10, 50, 300, 40), g_string, style);

        string a_string = "acceleration: " + acceleration.ToString();
        GUI.Label(new Rect(10, 90, 300, 40), a_string, style);
    }
}
