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
    private TextMeshProUGUI slider1Text;

    [SerializeField]
    private TextMeshProUGUI slider2Text;

    [SerializeField]
    private Slider player1Slider;

    [SerializeField]
    private Slider player2Slider;

    private float player1Speed;

    private float player2Speed;

    private void Awake()
    {
        back.onClick.AddListener(OnBackButtonClicked);

        player1Speed = player1.PlayerSpeed;
        player2Speed = player2.PlayerSpeed;
        
        slider1Text.text = player1Speed.ToString();
        player1Slider.value = player1Speed;

        slider2Text.text = player2Speed.ToString();
        player2Slider.value = player2Speed;

        player1Slider.onValueChanged.AddListener(updateFirstPlayerSpeed);
        player2Slider.onValueChanged.AddListener(updateSecondPlayerSpeed);

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

    private void updateFirstPlayerSpeed(float newSpeed)
    {
        newSpeed = player1Slider.value;
        player1Speed = newSpeed;

        player1.PlayerSpeed = player1Speed;

        slider1Text.text = player1Speed.ToString();
        player1Slider.value = player1Speed;
    }

    private void updateSecondPlayerSpeed(float updatedSpeed)
    {
        updatedSpeed = player2Slider.value;
        player2Speed = updatedSpeed;

        player2.PlayerSpeed = player2Speed;

        slider2Text.text = player2Speed.ToString();
        player2Slider.value = player2Speed;
    }
}
