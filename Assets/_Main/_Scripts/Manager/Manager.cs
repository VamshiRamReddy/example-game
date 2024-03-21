using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;


public class Manager : MonoBehaviour
{
    public static Manager instance = null;
    public static Manager Instance
    {
        get { return instance; }
    }


    [SerializeField] public SplashScreen SplashScreen;
    [SerializeField] public Modeselection ModeSelection;
    [SerializeField] public LoginScreen LoginScreen;
    [SerializeField] public AllProductsScreen FullProductScreen;
    [SerializeField] public EngineScreen EnginesScreen;

    [SerializeField] public ProductScreen ProductScreen;
    [SerializeField] public ProductModelScreen productModelScreen; 
    [SerializeField] public GameObject ashokLeylandLogo;

    [SerializeField] public Button BackButton;

    public Action OnBackAction;

   [SerializeField] private GameObject currentScreen, lastScreen;
    public GameObject CurrentScreen { get => currentScreen; set => currentScreen = value; }
    public GameObject LastScreen { get => lastScreen; set => lastScreen = value; }
    public bool isBackButtonClicked;

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
        // Cursor.lockState = CursorLockMode.Confined;
    }

    private void Start()
    {
        AllScreeensInitial();
        StartCoroutine(SplashScreenEnd());
        BackButton.onClick.RemoveAllListeners();
        BackButton.onClick.AddListener(OnBack);
    }
    private void AllScreeensInitial()
    {

        SplashScreen.gameObject.SetActive(true);
        SetCurrentLastScren(SplashScreen.gameObject, null);
        ModeSelection.gameObject.SetActive(false);
        LoginScreen.gameObject.SetActive(false);
        FullProductScreen.gameObject.SetActive(false);
        ProductScreen.gameObject.SetActive(false);
        productModelScreen.gameObject.SetActive(false);
        EnginesScreen.gameObject.SetActive(false);
    }

    IEnumerator SplashScreenEnd()
    {
        yield return new WaitForSeconds(3f);
        SplashScreen.gameObject.SetActive(false);
        ModeSelection.gameObject.SetActive(true);
        SetCurrentLastScren(ModeSelection.gameObject, SplashScreen.gameObject);
        ashokLeylandLogo.gameObject.SetActive(true);
    }

    public void SetCurrentLastScren(GameObject currentscr, GameObject lastscrn)
    {
        currentScreen = currentscr;
        lastScreen = lastscrn;

        EnableAndDisableScreens(currentscr, lastscrn);
    }
    public void EnableAndDisableScreens(GameObject currentscr, GameObject lastscrn)
    {
        if (currentscr!=null)
        {
            currentscr.SetActive(true);

        }
        if (lastscrn!=null)
        {
            lastscrn.SetActive(false);

        }

    }
    public void OnBack()
    {
        isBackButtonClicked = true;
        EnableAndDisableScreens(LastScreen, CurrentScreen);
    }
}




