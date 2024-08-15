using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField]
    private Button playButton;

    [SerializeField]
    private GameObject panelPause;

    [SerializeField]
    private Button settingsButton;

    [SerializeField]
    private GameObject settingsPanel;

    [SerializeField]
    private GameObject mainPanel;

    [SerializeField]
    private GameObject creditsPanel;

    [SerializeField]
    private Button creditsButton;
    
    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!panelPause.activeSelf)
            {
                panelPause.SetActive(true);

            } else if (panelPause.activeSelf)
            {
                panelPause.SetActive(false);
            }
        }
        
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(OnPlayButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        if(mainPanel.activeSelf)
        {
            mainPanel.SetActive(false);
        }
    }

    private void OnSettingsButtonClicked()
    {
        if(!settingsPanel.activeSelf)
        {
            mainPanel.SetActive(false);
            settingsPanel.SetActive(true);
            //Debug.Log("Clicked!");
        }
    }

    private void OnCreditsButtonClicked()
    {
        if (!creditsPanel.activeSelf)
        {
            mainPanel.SetActive(false);
            settingsPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }
    }

}
