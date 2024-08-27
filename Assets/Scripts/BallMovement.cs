using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    [SerializeField]
    private float initialVelocity = 6f;

    [SerializeField]
    private GameObject ball;

    private Rigidbody2D ballRb;


    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {

        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }
}
