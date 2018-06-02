using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameObject player;
    public static ExplosionController explosionController;
    public static EnemyController enemyController;

    static bool start = false;

    // Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        explosionController = GetComponent<ExplosionController>() as ExplosionController;
        enemyController = GetComponent<EnemyController>() as EnemyController;
	}

    public static void gameOver()
    {
        enemyController.startSpawning = false;
        enemyController.destroyAllEnemys();

        player.GetComponent<Player>().reset();

        start = false;
    }

    void OnGUI()
    {
        if (start)
        {

        }
        else
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "START"))
            {
                enemyController.startSpawning = true;
                start = true;
            }
        }
    }

}
