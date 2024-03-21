using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Modeselection : MonoBehaviour
{
    [SerializeField] private Button enterpriseModeButton;
    [SerializeField] private Button customerModeButton;
    private void OnEnable()
    {
        enterpriseModeButton.onClick.AddListener(ModeSelectionEnd);
        customerModeButton.onClick.AddListener(ModeSelectionEnd);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ModeSelectionEnd()
    {
       // Manager.instance.LoginScreen.gameObject.SetActive(true);
       // Manager.instance.ModeSelection.gameObject.SetActive(false);

        Manager.instance.SetCurrentLastScren(Manager.instance.LoginScreen.gameObject, Manager.instance.ModeSelection.gameObject);

    }
}
