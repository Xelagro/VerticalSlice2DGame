using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsForShop : MonoBehaviour
{



    public void StarFait()
    {
        if(ShopCurrency.CurrencyValue == 0)
        {

        }
        else{
            ShopCurrency.CurrencyValue -= 60;
        }
        
    }

    public void LegendaryHero()
    {
        if(ShopCurrency.CurrencyValue == 0)
        {

        }
        else 
        {
            ShopCurrency.CurrencyValue -= 300;
        }
       
    }
    
    public void GlamBurger()
    {
        if(ShopCurrency.CurrencyValue == 0)
        {

        }
        else
        {
            ShopCurrency.CurrencyValue -= 120;
        }
    }

    public void SteakThatLooksLikeMettatonsFace()
    {
        
        if(ShopCurrency.CurrencyValue == 0)
        {

        }
        else
        {
            ShopCurrency.CurrencyValue -= 500;
        }
    }
}
