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
        float randomX = Random.Range(0, 2f);
        float randomY = Random.Range(0, 4f);

        if(totalTime > timeToSpawn && !spawned)
        {
            obstacleInstance = Instantiate(obstaclePrefab, new Vector2(randomX, randomY), Quaternion.identity);
            spawned = true;
            obstacleCount++;
        }

        Destroy(obstacleInstance, 3);
        
    }

}
