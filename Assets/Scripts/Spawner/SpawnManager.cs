using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float timeToSpawn;

    [SerializeField]
    private float initialVelocity = 6f;

    private float totalTime;

    private bool spawned = false;

    private Rigidbody2D ballRb;

    private void Start()
    {
        totalTime = 0;
        ballRb = obstaclePrefab.GetComponent<Rigidbody2D>();
        Launch();
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

    private void Launch()
    {
        
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
        Debug.Log(ballRb);
    }
}
