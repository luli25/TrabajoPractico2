using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float timeToSpawn;

    private float totalTime;
    private bool spawned;
    private GameObject obstacle;

    private void Start()
    {
        totalTime = 0;
    }

    private void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime > timeToSpawn && !spawned)
        {
            obstacle = Instantiate(obstaclePrefab, new Vector2(0, 0), Quaternion.identity);
            spawned = true;
        }

        Destroy(obstacle, 3);
    }
}
