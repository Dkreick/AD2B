using System.Collections;
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

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            OnRightClick();
        }

        MovePlayerToMouse();
    }

    void OnRightClick()
    {
        UpdateClock.timeMultiplier = 100;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.transform.LookAt(target, Vector3.forward);
        target.z = transform.position.z;
        isMoving = true;
    }

    void MovePlayerToMouse()
    {
        if (isMoving)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, target, speed * Time.deltaTime);

            // eventTargetTime -= Time.deltaTime;
            // if (eventTargetTime <= 0.0f)
            // {
            //     GetRandomEvent();
            // }
        }

        if (player.transform.position == target)
        {
            isMoving = false;
            UpdateClock.timeMultiplier = 1;
        }
    }

    void GetRandomEvent()
    {
        panelToBattle.SetActive(true);
        isMoving = false;
    }
}