using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button playButton;
    public GameObject panelPause;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        if(panelPause.activeSelf)
        {
            panelPause.SetActive(false);
        }
    }
}
