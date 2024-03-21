using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ProductModelScreen : MonoBehaviour
{
    [SerializeField] List<Toggle> toggles = new List<Toggle>();
    [SerializeField]public  List<GameObject> allVehiclesFolder = new List<GameObject>();
    [SerializeField]public  List<Button> modelVechileFolderButton = new List<Button>();
    public GameObject Nextscreen, LastScreen;
    [SerializeField] private Button onBack;

    private void OnEnable()
    {
        if (Manager.instance.isBackButtonClicked)
        {
            Manager.instance.isBackButtonClicked = false;
            Manager.instance.LastScreen = LastScreen;
        }
        //  onBack.onClick.AddListener(back);
    }

    
    private void Start()
    {
        foreach (Toggle toggle in toggles)
        {
            toggle.onValueChanged.AddListener(delegate { ToggleValueChanged(toggle); });
        }

        for (int i = 0; i < Manager.instance.productModelScreen.modelVechileFolderButton.Count; i++)
        {
            int index = i;
            Manager.instance.productModelScreen.modelVechileFolderButton[i].onClick.AddListener(() => OnButtonClick(index));
        }
        Manager.instance.OnBackAction += back;
        ModelVechiles();
    }

    public  void ModelVechiles()
    {
        foreach (var item in modelVechileFolderButton)
        {
            item.onClick.AddListener(LoginScreeenEnd);
        }
    }

    private void back()
    {
        Debug.Log("This is being called");
        Manager.instance.SetCurrentLastScren(LastScreen, Nextscreen);
    }

    public void LoginScreeenEnd()
    {
       // Manager.instance.productModelScreen.gameObject.SetActive(false);
      //  Manager.instance.EnginesScreen.gameObject.SetActive(true);
        Manager.instance.SetCurrentLastScren(Manager.instance.EnginesScreen.gameObject, Manager.instance.productModelScreen.gameObject);
        Debug.Log("back");
    }
    private void ToggleValueChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            int index = toggles.IndexOf(changedToggle);

            foreach (GameObject vehicle in allVehiclesFolder)
            {
                vehicle.SetActive(false);
            }
            if (index >= 0 && index < allVehiclesFolder.Count)
            {
                allVehiclesFolder[index].SetActive(true);
            }         
        }
    }



    private void OnButtonClick(int index)
    {
       // Manager.instance.SetCurrentLastScren(Manager.instance.ProductScreen.gameObject, Manager.instance.LoginScreen.gameObject);


        if (index >= 0 && index <Manager.instance.EnginesScreen. allVehiclesEngineFolder.Count)
        {
            // Enable the image at the corresponding index
            Manager.instance.EnginesScreen. allVehiclesEngineFolder[index].gameObject.SetActive(true);
        }
    }

    public void DisableAllImages()
    {
        foreach (Image image in Manager.instance.EnginesScreen.allVehiclesEngineFolder)
        {
            image.enabled = false;
        }
    }
}
