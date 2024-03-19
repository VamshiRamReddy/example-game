using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductModelScreen : MonoBehaviour
{
    [SerializeField] private Button modelButton;
    private void Start()
    {
        modelButton.onClick.AddListener(productModelScreenEnd);
    }

    public void productModelScreenEnd()
    {
        Manager.instance.EnginesScreen.gameObject.SetActive(true);
        Manager.instance. productModelScreen.gameObject.SetActive(false);
    }
}
