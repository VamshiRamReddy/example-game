using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BusModelDataDetailsManager : MonoBehaviour
{
    public static BusModelDataDetailsManager instance = null;
    public static BusModelDataDetailsManager Instance
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
    [SerializeField] public BusModelData _busModelData;

    [Serializable]
   public  class BusModelData
    {
        public List<BusModelComponents> _busModelComponents = new List<BusModelComponents>();
    }
    [Serializable]
    public  class BusModelComponents
    {
        public Sprite busModelImage;
        public string busModelName;
        public string busModelNumber;
    }


}
