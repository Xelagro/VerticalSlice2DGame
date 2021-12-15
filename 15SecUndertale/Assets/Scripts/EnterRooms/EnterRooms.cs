using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterRooms : MonoBehaviour
{
    //bool settings
    [Header("Bool Settings")]
    public bool MttBurgers = false;
    public bool LeftHallWay = false;
    public bool RightHallWay = false;
    public bool Exits = false;

    //The audiosources for the hotel and shop music
    [Header("AudioSources")]
    public AudioSource HotelMusic;
    public AudioSource ShopMusic;

    //The MTT Burger menu
    [Header("UI")]
    public GameObject MTTBorgir;
    public GameObject End;

    //The gameobject of the player
    [Header("Player")]
    public GameObject Player;

    [Header("Random BurgerPants")]
    public GameObject[] Burgerpants;
    public ButtonsForShop GoneTexting;

    private void Start()
    {
        Player.SetActive(true);
        MTTBorgir.SetActive(false);
        End.SetActive(false);
        GoneTexting.GoneText.SetActive(false);
        GoneTexting.Text.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MTTBurger(collision);
        LeftHallWay1(collision);
        RightHallWay1(collision);
        Exites(collision);
    }
    public void MTTBurger(Collision2D collision)
    {
        if (MttBurgers == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                Player.SetActive(false);
                HotelMusic.Stop();
                ShopMusic.Play();
                MTTBorgir.SetActive(true);
                Burgerpants[Random.Range(0, Burgerpants.Length)].SetActive(true);
                GoneTexting.GoneText.SetActive(true);
            }
        }
    }

    public void LeftHallWay1(Collision2D coll)
    {
        if (LeftHallWay == true)
        {
            if (coll.gameObject.tag == "Player")
            {

            }
        }
    }

    public void RightHallWay1(Collision2D colls)
    {
        if (RightHallWay == true)
        {
            if (colls.gameObject.tag == "Player")
            {

            }
        }
    }

    public void Exites(Collision2D cole)
    {
        if (Exits == true)
        {
            if (cole.gameObject.tag == "Player")
            {
                Player.SetActive(false);
                End.SetActive(true);
            }
        }
    }

}
