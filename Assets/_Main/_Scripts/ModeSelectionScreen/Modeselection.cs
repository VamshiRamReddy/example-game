using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Modeselection : MonoBehaviour
{
    [SerializeField] private Button EnterpriseModeButton;
    private void OnEnable()
    {
        EnterpriseModeButton.onClick.AddListener(Manager.instance.ModeSelectionEnd);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
