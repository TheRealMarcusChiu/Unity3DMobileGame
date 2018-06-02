using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;
    private static GameObject enemys;

    public Vector3[] possibleSpawnPositions = new Vector3[16];
    public float spawnRatePerSecond = 1f;
    float timeLastSpawned = 0;
    public bool startSpawning = false;

	void Start ()
    {
        enemys = new GameObject();
	}

    void Update()
    {
        if(startSpawning)
        {
            if (timeLastSpawned > spawnRatePerSecond)
            {
                timeLastSpawned = 0;
                Vector3 nextSpawnPosition = possibleSpawnPositions[(int)Random.Range(0, 10)];
                spawnEnemy(nextSpawnPosition);
            }
            else
            {
                timeLastSpawned += Time.deltaTime;
            }
        } 
    }

    void spawnEnemy(Vector3 position)
    {
        GameObject clone = (GameObject)Instantiate(enemyPrefab, position, Quaternion.identity);
        clone.transform.parent = enemys.transform;
    }

    public void destroyAllEnemys()
    {
        foreach(Transform t in enemys.transform)
        {
            Destroy(t.gameObject);
        }
    }

}
