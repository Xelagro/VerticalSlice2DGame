using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopCurrency : MonoBehaviour
{
    //Already have made it before, quite fun to make
    [Header("Currency")]
    public static int CurrencyValue = 1000;
    Text Currency;
    
    // Start is called before the first frame update
    void Start()
    {
        Currency = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Currency.text =  CurrencyValue + "G";
    }

    
}
