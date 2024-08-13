using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float red = Random.Range(0, 1.0f);
        float green = Random.Range(0, 1.0f);
        float blue = Random.Range(0, 1.0f);

        Color updatedColor = new Color(red, green, blue);

        if(Input.GetKeyUp(KeyCode.R))
        {
            spriteRenderer.color = updatedColor;
        }
    }
}
