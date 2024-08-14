using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField]
    private Button playButton;

    [SerializeField]
    private GameObject panelPause;
    
    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
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
    }

    private void OnPlayButtonClicked()
    {
        if(panelPause.activeSelf)
        {
            panelPause.SetActive(false);
        }
    }

}
