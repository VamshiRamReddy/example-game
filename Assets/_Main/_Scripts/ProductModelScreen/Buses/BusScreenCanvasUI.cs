using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusScreenCanvasUI : MonoBehaviour
{
    [SerializeField] public Transform BusModelParent;

    private void Start()
    {
        SetModelComponetns();
    }
    public void SetModelComponetns()
    {
        for (int i = 0; i < BusModelDataDetailsManager.instance._busModelData._busModelComponents.Count; i++)
        {

            BusModelParent.GetChild(i).GetComponent<BusModelHelper>().BusModelImage.sprite = BusModelDataDetailsManager.instance._busModelData._busModelComponents[i].busModelImage;
            BusModelParent.GetChild(i).GetComponent<BusModelHelper>().BusModelName.text = BusModelDataDetailsManager.instance._busModelData._busModelComponents[i].busModelName;
            BusModelParent.GetChild(i).GetComponent<BusModelHelper>().BusModelsNumber.text = BusModelDataDetailsManager.instance._busModelData._busModelComponents[i].busModelNumber;
        }
    }

}
