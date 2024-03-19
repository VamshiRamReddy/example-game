using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance = null;
    public static Manager Instance
    {
        get { return instance; }
    }

    [SerializeField] public SplashScreen SplashScreen;
    [SerializeField] public Modeselection ModeSelection;
    [SerializeField] public GameObject LoginScreeen;
    [SerializeField] public GameObject FullProductScreen;
    [SerializeField] public GameObject ProductScreen;
    [SerializeField] public GameObject productModelScreen;
    [SerializeField] public GameObject EnginesScreen;

    [SerializeField] public GameObject ashokLeylandLogo;


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
       
    }
    private void AllScreeensInitial()
    {

        SplashScreen.gameObject.SetActive(true);
        ModeSelection.gameObject.SetActive(false);
        LoginScreeen.gameObject.SetActive(false);
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
        ashokLeylandLogo.gameObject.SetActive(true);
    }
}

