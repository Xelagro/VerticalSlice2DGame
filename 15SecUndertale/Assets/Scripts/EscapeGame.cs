using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeGame : MonoBehaviour
{
    [Header("Pausing the Game")]
    public GameObject PausingGame;
    public bool PausedGame = false;

    [Header("Items")]
    public GameObject ItemsScreen;
    public bool Itemss = false;

    [Header("Status")]
    public GameObject StatusPlayer;
    public bool Statusplayer = false;

    [Header("Cell")]
    public GameObject CellPhone;
    public bool CellingPhones = false;

    void Start()
    {
        PausingGame.SetActive(false);
        PausedGame = false;
        ItemsScreen.SetActive(false);
        Itemss = false;
        StatusPlayer.SetActive(false);
        Statusplayer = false;
        CellPhone.SetActive(false);
        CellingPhones = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PausedGame == false)
        {
            PausingGame.SetActive(true);
            Time.timeScale = 0f;
            PausedGame = true;
        }
        else if(Input.GetKeyDown(KeyCode.C) && PausedGame == true)
        {
            PausingGame.SetActive(false);
            Time.timeScale = 1f;
            PausedGame = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
    }

    public void Items()
    {
        if(Itemss == false)
        {
            ItemsScreen.SetActive(true);
            StatusPlayer.SetActive(false);
            CellPhone.SetActive(false);
            Itemss = true;
            Statusplayer = false;
            CellingPhones = false;
        }
        else
        {
            ItemsScreen.SetActive(false);
            Itemss = false;
        }
    }

    public void Status()
    {
        if(Statusplayer == false)
        {
            ItemsScreen.SetActive(false);
            StatusPlayer.SetActive(true);
            CellPhone.SetActive(false);
            Statusplayer = true;
            Itemss = false;
            CellingPhones = false;
        }
        else
        {
            StatusPlayer.SetActive(false);
            Statusplayer = false;
        }
    }

    public void Cellphone()
    {
        if(CellingPhones == false)
        {
            ItemsScreen.SetActive(false);
            StatusPlayer.SetActive(false);
            CellPhone.SetActive(true);
            Itemss = false;
            Statusplayer = false;
            CellingPhones = true;
        }
        else
        {
            CellPhone.SetActive(false);
            CellingPhones = false;
        }
    }
    
}
