using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;

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

    void Update()
    {
        Vector2 pos = transform.position;

        if(Input.GetKey(keyUp))
        {
            pos.y += speed * Time.deltaTime * 1000;
        }

        if(Input.GetKey(keyDown))
        {
            pos.y -= speed * Time.deltaTime * 1000;
        }

        if(Input.GetKey(keyRight))
        {
            pos.x += speed * Time.deltaTime * 1000;
        }

        if(Input.GetKey(keyLeft))
        {
            pos.x -= speed * Time.deltaTime * 1000;
        }

        transform.position = pos;

        Vector2 playerPosition = transform.position;
        playerPosition.y = Mathf.Clamp(playerPosition.y + pos.y * speed * Time.deltaTime, yBoundBottom, yBoundTop);
        transform.position = playerPosition;
    }

    public float PlayerSpeed
    {
        get { return speed; }
        set { speed = value;  }
    }
}
