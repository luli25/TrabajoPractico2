using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    [SerializeField]
    private float rotationAngle = 10.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, 0, rotationAngle);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 0, -rotationAngle);
        }
    }
}
