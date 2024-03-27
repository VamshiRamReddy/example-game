using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerSolutionsCanvasUI : MonoBehaviour
{
    [SerializeField] private Transform powerSolutionsModelsParent;
    private void Start()
    {
        SetVehicleModelComponent();
    }

    public void SetVehicleModelComponent()
    {
        for (int i = 0; i < PowerSolutionsModelDetailsManager.instance._PowerSolutionsModelData._PowerSolutionsModelComponents.Count; i++)
        {
           powerSolutionsModelsParent.GetChild(i).GetComponent<PowerSolutionsModelHelper>().powerSolutionsModelImage.sprite = PowerSolutionsModelDetailsManager.instance._PowerSolutionsModelData._PowerSolutionsModelComponents[i].PowerSolutionsModelImage;
           powerSolutionsModelsParent.GetChild(i).GetComponent<PowerSolutionsModelHelper>().powerSolutionsModelName.text = PowerSolutionsModelDetailsManager.instance._PowerSolutionsModelData._PowerSolutionsModelComponents[i].PowerSolutionsModelName;
            powerSolutionsModelsParent.GetChild(i).GetComponent<PowerSolutionsModelHelper>().powerSolutionsModelsNumber.text = PowerSolutionsModelDetailsManager.instance._PowerSolutionsModelData._PowerSolutionsModelComponents[i].PowerSolutionsModelNumber;
        }
    }
}
