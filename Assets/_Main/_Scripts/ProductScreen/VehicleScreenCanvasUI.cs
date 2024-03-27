using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleScreenCanvasUI :MonoBehaviour
{
    [SerializeField] private GameObject allVehiclesFolder;
    [SerializeField] private Transform vehiclesContent;
    private void Start()
    {
        SetVehicleComponents();
    }
    private void SetVehicleComponents()
    {
        for (int i = 0; i < VehicleDetailsManager.instance._vehicleData._vehicleComponents.Count; i++)
        {
            //vehiclesContent.GetChild(i).GetComponent<VehicleHelper>().vehicleButton.onClick.AddListener();
            vehiclesContent.GetChild(i).GetComponent<VehicleHelper>().vehicleImage.sprite = VehicleDetailsManager.instance._vehicleData._vehicleComponents[i].vehicleImage;
            vehiclesContent.GetChild(i).GetComponent<VehicleHelper>().vehicleName.text = VehicleDetailsManager.instance._vehicleData._vehicleComponents[i].vehicleText;
        }      
    }

}