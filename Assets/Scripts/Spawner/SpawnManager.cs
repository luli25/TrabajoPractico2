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
    private GameObject obstacle;

    private bool spawned = false;

    private void Start()
    {
        totalTime = 0;
    }

    private void Update()
    {
        totalTime += Time.deltaTime;
        float randomX = Random.Range(0.0f, 4.0f);
        float randomY = Random.Range(0.0f, 4.0f);


        if(totalTime > timeToSpawn && !spawned)
        {
            obstacle = Instantiate(obstaclePrefab, new Vector2(randomX, randomY), Quaternion.identity);
            spawned = true;
        }

        Destroy(obstacle, 3);
    }
}
