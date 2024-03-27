using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VehicleDetailsManager : MonoBehaviour
{
    public static VehicleDetailsManager instance = null;
    public static VehicleDetailsManager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }

    [SerializeField] public vehicleData _vehicleData;


    [Serializable]
    public class vehicleData
    {
        public List<VehicleComponents> _vehicleComponents = new List<VehicleComponents>();
    }
    [Serializable]
    public class VehicleComponents
    {
        public Sprite vehicleImage;
        public string vehicleText;
    }

}
