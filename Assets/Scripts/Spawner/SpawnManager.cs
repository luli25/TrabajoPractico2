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

    private void Start()
    {
        totalTime = 0;
    }

    private void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime > timeToSpawn && !spawned)
        {
            Instantiate(obstaclePrefab, new Vector2(0, 0), Quaternion.identity);
            spawned = true;
        }
    }
}
