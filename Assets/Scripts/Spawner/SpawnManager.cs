using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float timeToSpawn;

    private float totalTime;

    private bool spawned = false;

    private GameObject obstacleInstance;

    private int maxObstaclesSpawned = 4;

    private int obstacleCount;

    private void Start()
    {
        totalTime = 0;
    }

    private void Update()
    {

        totalTime += Time.deltaTime;
        float randomX = Random.Range(1, 7f);
        float randomY = Random.Range(1, 7f);

        if (totalTime > timeToSpawn && !spawned)
        {
            obstacleInstance = Instantiate(obstaclePrefab, new Vector2(randomX, randomY), Quaternion.identity);
            obstacleCount++;
            spawned = true;
        }
     
        Destroy(obstacleInstance, 3);

    }

}
