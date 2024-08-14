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
    
    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
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
        if(settingsPanel.activeSelf)
        {
            mainPanel.SetActive(false);
            settingsPanel.SetActive(true);
            Debug.Log("Clicked!");
        }
    }

}
