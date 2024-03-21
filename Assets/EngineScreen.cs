using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineScreen : MonoBehaviour
{
    public  GameObject Nextscreen = null,LastScreen;
    [SerializeField] private Button onBack;
    [SerializeField] public List<Image> allVehiclesEngineFolder = new List<Image>();

    private void OnEnable()
    {
        //onBack.onClick.AddListener(back);
    }

    private void back()
    {
        Manager.instance.SetCurrentLastScren(LastScreen, Nextscreen);
    }
    private void OnDisable()
    {
        Manager.instance.CurrentScreen = LastScreen;
    }
}
