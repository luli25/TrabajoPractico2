using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text player1ScoreText;

    [SerializeField]
    private TMP_Text player2ScoreText;

    [SerializeField]
    private Transform player1Transform;

    [SerializeField]
    private Transform player2Transform;

    [SerializeField]
    private BallMovement ball;

    private int player1Score;
    private int player2Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }

            return instance;
        }
    }

    public void Player1Scored()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
    }

    public void RestartAfterScore()
    {
        Transform ballTransform = ball.transform;
        Rigidbody2D rigidbody2D = ball.GetComponent<Rigidbody2D>();

        float xDirection = Random.Range(0, 2);
        float yDirection = Random.Range(0, 2);


        player1Transform.position = new Vector2(player1Transform.position.x, 0);
        player2Transform.position = new Vector2(player2Transform.position.x, 0);

        ballTransform.position = new Vector2(0, 0);
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.AddForce(new Vector2(xDirection, yDirection), ForceMode2D.Impulse);

    }
}
