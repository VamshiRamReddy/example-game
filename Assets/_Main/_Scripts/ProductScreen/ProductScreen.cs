using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductScreen : MonoBehaviour
{
    [SerializeField] private Button truckButton;
    private void Start()
    {
        truckButton.onClick.AddListener(ProductScreenEnd);
    }
    public void ProductScreenEnd()
    {
        Manager.instance.productModelScreen.gameObject.SetActive(true);
        Manager.instance.ProductScreen.gameObject.SetActive(false);

    }
}
