using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsForShop : MonoBehaviour
{
    //For Shop
    public void StarFait()
    {
        if(ShopCurrency.CurrencyValue > 60)
        {
            ShopCurrency.CurrencyValue -= 60;
        }
        else{
            
        }
    }
    //For Shop
    public void LegendaryHero()
    {
        if(ShopCurrency.CurrencyValue > 300)
        {
            ShopCurrency.CurrencyValue -= 300;
        }
        else 
        {
            
        }
       
    }
    //For Shop
    public void GlamBurger()
    {
        if(ShopCurrency.CurrencyValue > 120)
        {
            ShopCurrency.CurrencyValue -= 120;
        }
        else
        {
            
        }
    }
    //For Shop
    public void SteakThatLooksLikeMettatonsFace()
    {
        
        if(ShopCurrency.CurrencyValue > 500)
        {
            ShopCurrency.CurrencyValue -= 500;
        }
        else
        {
           
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
