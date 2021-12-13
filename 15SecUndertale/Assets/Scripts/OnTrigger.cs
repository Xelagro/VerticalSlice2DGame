using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    [Header("TextBoxes")]
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;

    [Header("Bools")]
    public bool Textbox1 = false;
    public bool Textbox2 = false;
    public bool Textbox3 = false;
    public bool Textbox4 = false;

    // Start is called before the first frame update
    void Start()
    {
        TextBox1.SetActive(false);
        TextBox2.SetActive(false);
        TextBox3.SetActive(false);
        TextBox4.SetActive(false);

        Textbox1 = false;
        Textbox2 = false;
        Textbox3 = false;
        Textbox4 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Monster1" && Textbox1 == false)
        {
            TextBox1.SetActive(true);
            Textbox1 = true;
        }
       

        if (collision.gameObject.tag == "Monster2" && Textbox2 == false)
        {
            TextBox2.SetActive(true);
            Textbox2 = true;
        }

        if (collision.gameObject.tag == "Monster3" && Textbox3 == false)
        {
            TextBox3.SetActive(true);
            Textbox3 = true;
        }


        if (collision.gameObject.tag == "Monster4" && Textbox4 == false)
        {
            TextBox4.SetActive(true);
            Textbox4 = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TextBox1.SetActive(false);
        TextBox2.SetActive(false);
        TextBox3.SetActive(false);
        TextBox4.SetActive(false);

        Textbox1 = false;
        Textbox2 = false;
        Textbox3 = false;
        Textbox4 = false;
    }

}
