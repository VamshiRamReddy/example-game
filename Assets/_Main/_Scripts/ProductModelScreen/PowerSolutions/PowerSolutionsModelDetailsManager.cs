using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PowerSolutionsModelDetailsManager : MonoBehaviour
{
    public static PowerSolutionsModelDetailsManager instance = null;
    public static PowerSolutionsModelDetailsManager Instance
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
    [SerializeField] public PowerSolutionsModelData _PowerSolutionsModelData;

    [Serializable]
    public class PowerSolutionsModelData
    {
        public List<PowerSolutionsModelComponents> _PowerSolutionsModelComponents = new List<PowerSolutionsModelComponents>();
    }
    [Serializable]
    public class PowerSolutionsModelComponents
    {
        public Sprite PowerSolutionsModelImage;
        public string PowerSolutionsModelName;
        public string PowerSolutionsModelNumber;
    }


}
