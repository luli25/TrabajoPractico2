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
    private bool isPaused;
    
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
            isPaused = true;
            deactivatePanelIfGameIsPaused();

            if (!panelPause.activeSelf)
            {
                panelPause.SetActive(true);
                panelPause.transform.GetChild(0).gameObject.SetActive(true);

            } else if (panelPause.activeSelf)
            {
                panelPause.SetActive(false);
                panelPause.transform.GetChild(0).gameObject.SetActive(false);
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
        if(panelPause.activeSelf)
        {
            panelPause.SetActive(false);
        }
    }

    private void OnSettingsButtonClicked()
    {
        if(!settingsPanel.activeSelf)
        {
            mainPanel.SetActive(false);
            settingsPanel.SetActive(true);
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

    private void deactivatePanelIfGameIsPaused()
    {
        if(isPaused == true)
        {
            mainPanel.SetActive(false);
            settingsPanel.SetActive(false);
            creditsPanel.SetActive(false);
        } else
        {
            mainPanel.SetActive(true);
        }
    }

}
