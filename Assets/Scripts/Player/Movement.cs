using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 6f;

    [SerializeField]
    private KeyCode keyUp;

    [SerializeField]
    private KeyCode keyDown;

    [SerializeField]
    private KeyCode keyLeft;

    [SerializeField]
    private KeyCode keyRight;

    private float yBoundTop = 4.50f;
    private float yBoundBottom = -2.34f;

    private float playerMovement;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {   
        Move();
    }

    public float PlayerSpeed
    {
        get { return speed; }
        set { speed = value;  }
    }

    private void Move()
    {
        if (Input.GetKey(keyUp))
        {
            playerMovement = Input.GetAxisRaw("Vertical");
            rb.AddForce(Vector2.up * speed * Time.deltaTime * 1000);
        }

        if (Input.GetKey(keyDown))
        {
            playerMovement = Input.GetAxisRaw("Vertical");
            rb.AddForce(Vector2.down * speed * Time.deltaTime * 1000);
        }

        if (Input.GetKey(keyLeft))
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime * 1000);
        }

        if (Input.GetKey(keyRight))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime * 1000);
        }
    }
}
