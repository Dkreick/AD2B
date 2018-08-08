﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 target;
    public float speed;
    public static bool isMoving;
    public float eventTargetTime;
    public GameObject panelToBattle;

    void OnMouseDown()
    {
        UpdateClock.timeMultiplier = 100;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.transform.LookAt(target, Vector3.forward);
        target.z = transform.position.z;
        isMoving = true;
    }

    void Update()
    {
        if (isMoving && player.transform.localPosition.y <= -132)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, target, speed * Time.deltaTime);

            ClampPosition();

//            eventTargetTime -= Time.deltaTime;
//            if (eventTargetTime <= 0.0f)
//            {
//                getRandomEvent();
//            }
        }

        if (player.transform.position == target)
        {
            isMoving = false;
            UpdateClock.timeMultiplier = 1;
        }
    }

    void ClampPosition()
    {
        if (player.transform.localPosition.y > -132)
        {
            isMoving = false;
            UpdateClock.timeMultiplier = 1;
        }    
    }

    void getRandomEvent()
    {
        panelToBattle.SetActive(true);
        isMoving = false;
    }
}