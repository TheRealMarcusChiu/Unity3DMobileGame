using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour
{

    public float movementSpeed = 5f;
    public float mouseSensitivity = 1f;

    public float upDownRange = 60f;
    //float verticalRotation = 0;


    public GameObject cam;

    void Start ()
    {
	}

	void Update ()
    {
        //Rotation
        /*verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        cam.transform.rotation = Quaternion.Euler(verticalRotation, 0, 0);*/
        
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        //Movement
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController cc = GetComponent<CharacterController>();

        cc.SimpleMove(speed);
	}
}
