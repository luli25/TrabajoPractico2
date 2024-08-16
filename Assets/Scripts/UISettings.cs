using System.Collections;
using System.Collections.Generic;
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

    private void Awake()
    {
        back.onClick.AddListener(OnBackButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
