using System.Collections;
using System.Collections.Generic;
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
    private Slider player1Slider;

    [SerializeField]
    private Slider player2Slider;

    [SerializeField]
    private TextMeshProUGUI player1SliderText;

    [SerializeField]
    private TextMeshProUGUI player2SliderText;

    [SerializeField]
    private GameObject player1;

    [SerializeField]
    private GameObject player2;

    Movement movement;
    float playerSpeed;

    private void Awake()
    {
        back.onClick.AddListener(OnBackButtonClicked);
        movement = player1.GetComponent<Movement>();

        playerSpeed = movement.playerSpeed;
        player1SliderText.text = playerSpeed.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        back.onClick.RemoveListener(OnBackButtonClicked);
    }

    private void OnValueChanged()
    {
        float newSpeed = player1Slider.value;
        playerSpeed = newSpeed;
    }

    private void OnBackButtonClicked()
    {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}
