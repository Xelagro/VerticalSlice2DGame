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
        if(MttBurgers == true)
        {
            if(collision.gameObject.tag == "MTTBorgir")
            {
                Player.SetActive(false);
                MTTBorgir.SetActive(true);
            }
        }
        else if(LeftHallWay == true)
        {
            if(collision.gameObject.tag == "LeftHallway")
            {

            }
        }
        else if(RightHallWay == true)
        {
            if(collision.gameObject.tag == "RightHallway")
            {

            }
        }
        else if(Exits == false)
        {
            if(collision.gameObject.tag == "Exit")
            {
                Player.SetActive(false);
                End.SetActive(true);
            }
        }
    }
}
