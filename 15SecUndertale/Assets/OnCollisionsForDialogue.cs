using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionsForDialogue : MonoBehaviour
{
    [Header("Booleans for Dialogue")]
    public bool monster = false;
    public bool monster1 = false;
    public bool monster2 = false;
    public bool monster3 = false;
    public bool elevator = false;
    public bool savePoint = false;
    public bool fountain = false;

    [Header("SetActive to UI when chosen with bools")]
    public GameObject Monster;
    public GameObject Monster1;
    public GameObject Monster2;
    public GameObject Monster3;
    public GameObject Elevator;
    public GameObject SavePoint;
    public GameObject Fountain;

    // Start is called before the first frame update
    void Start()
    {
        Monster.SetActive(false);
        Monster1.SetActive(false);
        Monster2.SetActive(false);
        Monster3.SetActive(false);
        Elevator.SetActive(false);
        SavePoint.SetActive(false);
        Fountain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (monster == true && Input.GetKeyDown(KeyCode.Z))
        {
            Monster.SetActive(true);
        }
        if (monster1 == true && Input.GetKeyDown(KeyCode.Z))
        {
            Monster1.SetActive(true);
        }
        if (monster2 == true && Input.GetKeyDown(KeyCode.Z))
        {
            Monster2.SetActive(true);
        }
        if (monster3 == true && Input.GetKeyDown(KeyCode.Z))
        {
            Monster3.SetActive(true);
        }
        if (elevator == true && Input.GetKeyDown(KeyCode.Z))
        {
            Elevator.SetActive(true);
        }
        if (savePoint == true && Input.GetKeyDown(KeyCode.Z))
        {
            SavePoint.SetActive(true);
        }
        if (fountain == true && Input.GetKeyDown(KeyCode.Z))
        {
            Fountain.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Update();
        }
    }
}
