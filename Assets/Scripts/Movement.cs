using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.01f;
    private float rotationAngleLeft = 10.0f;
    private float rotationAngleRight = -10.0f;

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
        Quaternion rotation = transform.rotation;

        if(Input.GetKey(keyUp))
        {
            pos.y += speed;
        }

        if(Input.GetKey(keyDown))
        {
            pos.y -= speed;
        }

        if(Input.GetKey(keyRight))
        {
            pos.x += speed;
        }

        if(Input.GetKey(keyLeft))
        {
            pos.x -= speed;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, 0, rotationAngleLeft);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 0, rotationAngleRight);
        }

        transform.position = pos;

    }
}
