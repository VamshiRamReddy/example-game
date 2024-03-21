using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoginScreen : MonoBehaviour
{
    
   
    [SerializeField] private Button loginButton;
    private void OnEnable()
    {
        loginButton.onClick.AddListener(LoginScreeenEnd);
    }
    public void LoginScreeenEnd()
    {
        //Manager.instance.LoginScreen.gameObject.SetActive(false);
        Manager.instance.FullProductScreen.gameObject.SetActive(true);

        //Manager.instance.CurrentScreen = Manager.instance.ProductScreen.gameObject;
      //  Manager.instance.CurrentScreen.SetActive(true);

        Manager.instance.SetCurrentLastScren(Manager.instance.ProductScreen.gameObject, Manager.instance.LoginScreen.gameObject);
    }
}
