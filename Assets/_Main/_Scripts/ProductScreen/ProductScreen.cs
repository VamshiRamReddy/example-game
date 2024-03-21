using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductScreen : MonoBehaviour
{
    [SerializeField]public  List<Button> allVehiclesButtonList = new List<Button>();

    private void Start()
    {
        foreach (Button button in allVehiclesButtonList)
        {
            button.onClick.AddListener(delegate { ButtonClicked(button); });
        } 
    }
    private void ButtonClicked(Button clickedButton)
    {
        Manager.instance.productModelScreen.gameObject.SetActive(true);
        Manager.instance.ProductScreen.gameObject.SetActive(false);
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
