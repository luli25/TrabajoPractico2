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

    void Update()
    {
        Vector3 pos = transform.position;

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
    }

    public float PlayerSpeed
    {
        get { return speed; }
        set { speed = value;  }
    }
}
