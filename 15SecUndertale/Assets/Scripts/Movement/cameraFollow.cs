using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float followSpeed, yPos;

    private Transform player;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 targetPos = player.position;
        Vector2 smoothPos = Vector2.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);

        transform.position = new Vector3(smoothPos.x, smoothPos.y + yPos, -15f);
    }
}