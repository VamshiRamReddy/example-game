using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TruckModelDetailsManager : MonoBehaviour
{
    public static TruckModelDetailsManager instance = null;
    public static TruckModelDetailsManager Instance
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
    [SerializeField] public TruckModelData _truckModelData;


    [Serializable]
    public class TruckModelData
    {
       public  List<TruckModelComponents> _TruckModelComponents = new List<TruckModelComponents>();
    }
    [System.Serializable]
    public class TruckModelComponents
    {
        public Sprite TruckModelImage;
        public string TruckModelName;
        public string TruckModelNumber;
    }
}
