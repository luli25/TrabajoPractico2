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

    private void Start()
    {
        totalTime = 0;
    }

    private void Update()
    {
        
        totalTime += Time.deltaTime;


        if(totalTime > timeToSpawn && !spawned)
        {
            obstacleInstance = Instantiate(obstaclePrefab, new Vector2(0, 0), Quaternion.identity);
            spawned = true;
        }

        Destroy(obstacleInstance, 3);
        

        
    }
}
