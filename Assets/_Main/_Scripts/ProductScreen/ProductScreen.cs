using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductScreen : MonoBehaviour
{
    [SerializeField]public  List<Button> allVehiclesButtonList = new List<Button>();
    public GameObject Nextscreen, LastScreen;
    private void Start()
    {
        foreach (Button button in allVehiclesButtonList)
        {
            button.onClick.AddListener(delegate { ButtonClicked(button); });
        } 
    }
    private void OnEnable()
    {
        if (Manager.instance.isBackButtonClicked)
        {
            Manager.instance.isBackButtonClicked = false;
            Manager.instance.LastScreen = null;
            Manager.instance.CurrentScreen = this.gameObject;
        }
        //  onBack.onClick.AddListener(back);
    }
    private void ButtonClicked(Button clickedButton)
    {
       // Manager.instance.productModelScreen.gameObject.SetActive(true);
      //  Manager.instance.ProductScreen.gameObject.SetActive(false);

        Manager.instance.SetCurrentLastScren(Manager.instance.productModelScreen.gameObject, Manager.instance.ProductScreen.gameObject);


        int index = allVehiclesButtonList.IndexOf(clickedButton);

        if (index >= 0 && index < Manager.instance.productModelScreen.allVehiclesFolder.Count)
        {
            Manager.instance.productModelScreen.allVehiclesFolder[index].SetActive(true);
        }
        else
        {
            Debug.LogError("Index out of range.");
        }
    }


}
