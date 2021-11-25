using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterRooms : MonoBehaviour
{

    [Header("Bool Settings")]
    public bool MttBurgers = false;
    public bool LeftHallWay = false;
    public bool RightHallWay = false;
    public bool Exits = false;

    [Header("UI")]
    public GameObject MTTBorgir;
    public GameObject End;

    [Header("Player")]
    public GameObject Player;

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
            if (collision.gameObject.tag == "MTTBorgir")
            {
                Player.SetActive(false);
                MTTBorgir.SetActive(true);
            }
        }
    }

    public void LeftHallWay1(Collision2D coll)
    {
        if (LeftHallWay == true)
        {
            if (coll.gameObject.tag == "LeftHallway")
            {

            }
        }
    }

    public void RightHallWay1(Collision2D colls)
    {
        if (RightHallWay == true)
        {
            if (colls.gameObject.tag == "RightHallway")
            {

            }
        }
    }

    public void Exites(Collision2D cole)
    {
        if (Exits == false)
        {
            if (cole.gameObject.tag == "Exit")
            {
                Player.SetActive(false);
                End.SetActive(true);
            }
        }
    }
}
