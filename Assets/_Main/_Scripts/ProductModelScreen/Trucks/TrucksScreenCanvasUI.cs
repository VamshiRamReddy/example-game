using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrucksScreenCanvasUI : MonoBehaviour
{
    [SerializeField] private Transform truckModelsParent;
    private void Start()
    {
        SetVehicleModelComponent();
    }

    public void SetVehicleModelComponent()
    {
        for (int i = 0; i < TruckModelDetailsManager.instance._truckModelData._TruckModelComponents.Count; i++)
        {
            truckModelsParent.GetChild(i).GetComponent<TruckModelHelper>().vehicleImage.sprite = TruckModelDetailsManager.instance._truckModelData._TruckModelComponents[i].TruckModelImage;
           truckModelsParent.GetChild(i).GetComponent<TruckModelHelper>().vehicleName.text = TruckModelDetailsManager.instance._truckModelData._TruckModelComponents[i].TruckModelName;
           truckModelsParent.GetChild(i).GetComponent<TruckModelHelper>().vehicleModelNumber.text = TruckModelDetailsManager.instance._truckModelData._TruckModelComponents[i].TruckModelNumber;
        }
    }
}
