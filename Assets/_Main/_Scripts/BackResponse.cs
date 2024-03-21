using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackResponse : MonoBehaviour
{
    

   // public Backresponse backresponse;

    public void OnBack()
    {
        Manager.instance.EnableAndDisableScreens(Manager.instance.LastScreen, Manager.instance.CurrentScreen);
        //switch (backresponse)
        //{
           
        //    case Backresponse.VehicleModelScreen:
        //        {
        //            Manager.instance.productModelScreen.gameObject.SetActive(false);
        //        }
        //        break;
        //    case Backresponse.VehicleEngineScreen:
        //        break;
        //    default:
        //        break;
        //}
    }
}
    //public enum Backresponse
    //{
    //    VehicleScreen = 1,
    //    VehicleModelScreen= 2,
    //    VehicleEngineScreen = 3
    //}
