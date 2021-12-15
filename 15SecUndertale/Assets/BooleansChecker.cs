using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleansChecker : MonoBehaviour
{
    public OnCollisionsForDialogue Bools;
    public OnCollisionsForDialogue Bools1;
    public OnCollisionsForDialogue Bools2;
    public OnCollisionsForDialogue Bools3;
    public OnCollisionsForDialogue Bools4;
    public OnCollisionsForDialogue Bools5;
    public OnCollisionsForDialogue Bools6;
    public OnCollisionsForDialogue Bools7;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Bools.monster = true;
        }
        if (collision.gameObject.tag == "Monster1")
        {
            Bools1.monster1 = true;
        }
        if (collision.gameObject.tag == "Monster2")
        {
            Bools2.monster2 = true;
        }
        if (collision.gameObject.tag == "Monster3")
        {
            Bools3.monster3 = true;
        }
        if(collision.gameObject.tag == "ElevatorDoor")
        {
            Bools4.elevator = true;
        }
        if(collision.gameObject.tag == "SavePoint")
        {
            Bools5.savePoint = true;
        }
        if(collision.gameObject.tag == "Fountain")
        {
            Bools6.fountain = true;
        }
        if(collision.gameObject.tag == "Chest")
        {
            Bools7.chest = true;
        }
    }
}
