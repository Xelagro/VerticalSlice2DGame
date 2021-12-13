using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsForShop : MonoBehaviour
{
    //For Shop
    public void StarFait()
    {
        if(ShopCurrency.CurrencyValue == 0)
        {

        }
        else{
            ShopCurrency.CurrencyValue -= 60;
        }
    }
    //For Shop
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
    //For Shop
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
    //For Shop
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

    public void SimplePixel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HighDefinition()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
