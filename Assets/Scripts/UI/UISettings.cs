using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UISettings : MonoBehaviour
{
    [SerializeField]
    private Button back;

    [SerializeField]
    private GameObject mainPanel;

    [SerializeField]
    private GameObject settingsPanel;

    [SerializeField]
    private Movement player1;

    [SerializeField]
    private Movement player2;

    [SerializeField]
    private TextMeshProUGUI speedSlider1Text;

    [SerializeField]
    private TextMeshProUGUI speedSlider2Text;

    [SerializeField]
    private Slider player1Slider_Speed;

    [SerializeField]
    private Slider player2Slider_Speed;

    [SerializeField]
    private TMP_Dropdown colorDropdownP1;

    [SerializeField]
    private TMP_Dropdown colorDropdownP2;

    [SerializeField]
    private Slider player1Slider_Scale;

    [SerializeField]
    private Slider player2Slider_Scale;

    [SerializeField]
    private TextMeshProUGUI scaleSliderText1;

    [SerializeField]
    private TextMeshProUGUI scaleSliderText2;

    private SpriteRenderer spriteP1;

    private SpriteRenderer spriteP2;

    private float player1Speed;

    private float player2Speed;

    private float player1Scale;

    private float player2Scale;

    private void Awake()
    {
        back.onClick.AddListener(OnBackButtonClicked);

        player1Speed = player1.PlayerSpeed;
        player2Speed = player2.PlayerSpeed;

        speedSlider1Text.text = player1Speed.ToString("#.##");
        player1Slider_Speed.value = player1Speed;

        speedSlider2Text.text = player2Speed.ToString("#.##");
        player2Slider_Speed.value = player2Speed;

        player1Slider_Speed.onValueChanged.AddListener(UpdateFirstPlayerSpeed);
        player2Slider_Speed.onValueChanged.AddListener(UpdateSecondPlayerSpeed);

        colorDropdownP1.onValueChanged.AddListener(ChangePlayer1Color);
        colorDropdownP2.onValueChanged.AddListener(ChangePlayer2Color);

        spriteP1 = player1.gameObject.GetComponent<SpriteRenderer>();
        spriteP2 = player2.gameObject.GetComponent<SpriteRenderer>();

        player1Scale = spriteP1.gameObject.transform.localScale.y;
        player2Scale = spriteP2.gameObject.transform.localScale.y;

        scaleSliderText1.text = player1Scale.ToString("#.##");
        scaleSliderText2.text = player2Scale.ToString("#.##");

        player1Slider_Scale.onValueChanged.AddListener(UpdatePlayer1Scale);
        player2Slider_Scale.onValueChanged.AddListener(UpdatePlayer2Scale);

    }

    private void OnDestroy()
    {
        back.onClick.RemoveListener(OnBackButtonClicked);
    }

    private void OnBackButtonClicked()
    {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    private void UpdateFirstPlayerSpeed(float newSpeed)
    {
        newSpeed = player1Slider_Speed.value;
        player1Speed = newSpeed;

        player1.PlayerSpeed = player1Speed;

        speedSlider1Text.text = player1Speed.ToString("#.##");
        player1Slider_Speed.value = player1Speed;
    }

    private void UpdateSecondPlayerSpeed(float updatedSpeed)
    {
        updatedSpeed = player2Slider_Speed.value;
        player2Speed = updatedSpeed;

        player2.PlayerSpeed = player2Speed;

        speedSlider2Text.text = player2Speed.ToString("#.##");
        player2Slider_Speed.value = player2Speed;
    }

    private void ChangePlayer1Color(int choosedColor)
    {

        choosedColor = colorDropdownP1.value;

        switch(choosedColor)
        {
            case 0:
                spriteP1.material.color = Color.blue;
                break;
            case 1:
                spriteP1.material.color = Color.gray;
                break;
            case 3:
                spriteP1.material.color = Color.green;
                break;
            case 4:
                spriteP1.material.color = Color.red;
                break;
            case 5:
                spriteP1.material.color = Color.white;
                break;
            case 6:
                spriteP1.material.color = Color.white;
                break;
        }
    }

    private void ChangePlayer2Color(int choosedColor)
    {

        choosedColor = colorDropdownP2.value;

        switch (choosedColor)
        {
            case 0:
                spriteP2.material.color = Color.blue;
                break;
            case 1:
                spriteP2.material.color = Color.black;
                break;
            case 3:
                spriteP2.material.color = Color.green;
                break;
            case 4:
                spriteP2.material.color = Color.red;
                break;
            case 5:
                spriteP2.material.color = Color.white;
                break;
            case 6:
                spriteP2.material.color = Color.white;
                break;
        }
    }

    private void UpdatePlayer1Scale(float updatedScale)
    {
        updatedScale = player1Slider_Scale.value;
        player1Scale = updatedScale;

        Vector2 newScale = new Vector2(1.12f, updatedScale);
        spriteP1.transform.localScale = newScale;

        scaleSliderText1.text = player1Scale.ToString("#.##");
        player1Slider_Scale.value = player1Scale;
    }

    private void UpdatePlayer2Scale(float updatedScale)
    {
        updatedScale = player2Slider_Scale.value;
        player2Scale = updatedScale;

        Vector2 newScale = new Vector2(1.12f, updatedScale);
        spriteP2.transform.localScale = newScale;

        scaleSliderText2.text = player2Scale.ToString("#.##");
        player2Slider_Scale.value = player2Scale;
    }
}
