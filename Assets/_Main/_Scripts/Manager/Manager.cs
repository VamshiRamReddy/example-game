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

    [SerializeField] public GameObject SplashScreen;
    [SerializeField] public GameObject ModeSelection;
    [SerializeField] public GameObject LoginScreeen;
    [SerializeField] public GameObject FullProductScreen;
    [SerializeField] public GameObject ProductScreen;
    [SerializeField] public GameObject productModelScreen;
    [SerializeField] public GameObject EnginesScreen;


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
        AllScreeensinitial();
        StartCoroutine(SplashScreenEnd());
    }
    private void AllScreeensinitial()
    {

        SplashScreen.SetActive(true);
        ModeSelection.SetActive(false);
        LoginScreeen.SetActive(false);
        FullProductScreen.SetActive(false);
        ProductScreen.SetActive(false);
        productModelScreen.SetActive(false);
        EnginesScreen.SetActive(false);
    }

    IEnumerator SplashScreenEnd()
    {
        yield return new WaitForSeconds(3f);
        SplashScreen.SetActive(false);
        ModeSelection.SetActive(true);
    }
    public void ModeSelectionEnd()
    {
        ModeSelection.SetActive(false);
        LoginScreeen.SetActive(true);
    }
    public void LoginScreeenEnd()
    {
        LoginScreeen.SetActive(false);
        FullProductScreen.SetActive(true);

    }
    public void ProductScreenEnd()
    {
        ProductScreen.SetActive(false);
        productModelScreen.SetActive(true);

    }
    public void productModelScreenEnd()
    {
        productModelScreen.SetActive(false);
        EnginesScreen.SetActive(true);
    }
}

