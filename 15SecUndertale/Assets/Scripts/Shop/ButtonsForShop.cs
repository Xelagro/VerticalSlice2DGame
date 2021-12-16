using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsForShop : MonoBehaviour
{

    public GameObject Player;
    public Transform OutOfShop;
    public GameObject Shop;
    public AudioSource HotelMusic;
    public AudioSource StopShopMusic;
    public EnterRooms BurgerPants;
    public GameObject LaughingBurgerPants;
    public GameObject GoneText;
    public GameObject Text;

    void Start()
    {
        Player.SetActive(true);
        Shop.SetActive(false);
        LaughingBurgerPants.SetActive(false);
        Text.SetActive(false);
    }

    //For Shop
    public void StarFait()
    {
        if(ShopCurrency.CurrencyValue > 60)
        {
            if (BurgerPants.Burgerpants[0].activeSelf)
            {
                BurgerPants.Burgerpants[0].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 60;
                GoneText.SetActive(false);
                Text.SetActive(true);
                ShopCurrency.Currency.text = ShopCurrency.CurrencyValue + "G";
            }
            if (BurgerPants.Burgerpants[1].activeSelf)
            {
                BurgerPants.Burgerpants[1].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 60;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[2].activeSelf)
            {
                BurgerPants.Burgerpants[2].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 60;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[3].activeSelf)
            {
                BurgerPants.Burgerpants[3].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 60;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[4].activeSelf)
            {
                BurgerPants.Burgerpants[4].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 60;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
        }
        else{
            
        }
    }
    //For Shop
    public void LegendaryHero()
    {
        if(ShopCurrency.CurrencyValue > 300)
        {
            if(BurgerPants.Burgerpants[0].activeSelf)
            {
                BurgerPants.Burgerpants[0].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 300;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[1].activeSelf)
            {
                BurgerPants.Burgerpants[1].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 300;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[2].activeSelf)
            {
                BurgerPants.Burgerpants[2].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 300;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[3].activeSelf)
            {
                BurgerPants.Burgerpants[3].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 300;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[4].activeSelf)
            {
                BurgerPants.Burgerpants[4].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 300;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
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
            if (BurgerPants.Burgerpants[0].activeSelf)
            {
                BurgerPants.Burgerpants[0].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 120;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[1].activeSelf)
            {
                BurgerPants.Burgerpants[1].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 120;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[2].activeSelf)
            {
                BurgerPants.Burgerpants[2].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 120;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[3].activeSelf)
            {
                BurgerPants.Burgerpants[3].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 120;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[4].activeSelf)
            {
                BurgerPants.Burgerpants[4].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 120;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
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
            if (BurgerPants.Burgerpants[0].activeSelf)
            {
                BurgerPants.Burgerpants[0].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 500;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[1].activeSelf)
            {
                BurgerPants.Burgerpants[1].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 500;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[2].activeSelf)
            {
                BurgerPants.Burgerpants[2].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 500;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[3].activeSelf)
            {
                BurgerPants.Burgerpants[3].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 500;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
            if (BurgerPants.Burgerpants[4].activeSelf)
            {
                BurgerPants.Burgerpants[4].SetActive(false);
                LaughingBurgerPants.SetActive(true);
                ShopCurrency.CurrencyValue -= 500;
                GoneText.SetActive(false);
                Text.SetActive(true);
            }
        }
        else
        {
           
        }
    }

    public void ExitShop()
    {
        if (Player.activeSelf == false && Shop.activeSelf == true)
        {
            if (BurgerPants.Burgerpants[0].activeSelf)
            {
                GameObject.Find("Burgerpants_2").SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
                
            }
            if (BurgerPants.Burgerpants[1].activeSelf)
            {
                GameObject.Find("Burgerpants_2 (1)").SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
            }
            if (BurgerPants.Burgerpants[2].activeSelf)
            {
                GameObject.Find("Burgerpants_21").SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
            }
            if (BurgerPants.Burgerpants[3].activeSelf)
            {
                GameObject.Find("Burgerpants_22").SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
            }
            if (BurgerPants.Burgerpants[4].activeSelf)
            {
                GameObject.Find("Burgerpants_23").SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
            }
            if (LaughingBurgerPants.activeSelf)
            {
                LaughingBurgerPants.SetActive(false);
                Player.SetActive(true);
                Player.transform.position = new Vector3(0.487f, 0.227f, 18f);
                Shop.SetActive(false);
                HotelMusic.Play();
                StopShopMusic.Stop();
                if (Text.activeSelf)
                {
                    Text.SetActive(false);
                }
            }
            
            
        }
    }


   

}
