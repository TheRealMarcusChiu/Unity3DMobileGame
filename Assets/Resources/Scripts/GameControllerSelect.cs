using UnityEngine;
using System.Collections;

public class GameControllerSelect : MonoBehaviour
{
    public static GameObject selected;

    public static void selectObject(GameObject go)
    {
        /*if (selected != null && go.tag != "Space")
            selected.GetComponent<MeshRenderer>().material.color = Color.white;

        if (go.tag == "Tile")
        {
            selected = go;
            selected.GetComponent<MeshRenderer>().material.color = Color.cyan;
        }

        if (go.tag == "Space")
        {
            if (selected.tag == "Tile")
            {
                selected.transform.position = new Vector3(go.transform.position.x, 1f, 0f);
            }
        }*/

        /*if (GUIUtility.hotControl == 0)
{
    if (Input.GetMouseButtonDown(0))
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            GameControllerSelect.selectObject(hit.collider.gameObject);
    }
}*/
    }
}
