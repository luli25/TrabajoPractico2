using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    [SerializeField]
    private float initialVelocity = 4f;

    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private float velocityMultiplier = 1.1f;

    private Rigidbody2D ballRb;


    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Player2Scored();
            GameManager.Instance.RestartAfterScore();
            Launch();
        } else
        {
            GameManager.Instance.Player1Scored();
            GameManager.Instance.RestartAfterScore();
            Launch();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ballRb.velocity *= velocityMultiplier;
        }
    }

    private void Launch()
    {

        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.AddForce(new Vector2(xVelocity, yVelocity) * initialVelocity, ForceMode2D.Impulse);
    }
}
