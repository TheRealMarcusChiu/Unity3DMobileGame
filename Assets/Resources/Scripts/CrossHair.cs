using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    bool ontarget = false;

    public GameObject black;
    public GameObject red;

    void Start ()
    {
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
    }
	
	void FixedUpdate ()
    {
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.tag == "Enemy")
            {
                black.SetActive(false);
                red.SetActive(true);

            }
            else
            {
                black.SetActive(true);
                red.SetActive(false);
            }
        }
        else
        {
            black.SetActive(true);
            red.SetActive(false);
        }
    }
}
