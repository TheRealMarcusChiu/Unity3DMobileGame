using UnityEngine;
using System.Collections;

public class deltaTime : MonoBehaviour {
    public float speed = 8f;
    public float countdown = 3.0f;
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            Debug.Log("time!");

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }
}
