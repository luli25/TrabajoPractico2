using UnityEditor;
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

    [SerializeField]
    private Button exitButton;
    
    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        exitButton.onClick.AddListener(ExitPlayMode);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
            deactivatePanelIfGameIsPaused();
            EditorApplication.isPaused = true;

            if (!panelPause.activeSelf)
            {
                panelPause.SetActive(true);
                panelPause.transform.GetChild(0).gameObject.SetActive(true);

            } else if (panelPause.activeSelf)
            {
                panelPause.SetActive(false);
                panelPause.transform.GetChild(0).gameObject.SetActive(false);
                EditorApplication.isPaused = false;
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

    private void ExitPlayMode()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }

}
