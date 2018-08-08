using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectPlace : MonoBehaviour
{
    public Text locationText;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Place")
        {
            PlayerData.location = col.gameObject.name;
            locationText.text = "Current Location: " + col.gameObject.name;
            MovePlayer.isMoving = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Border")
        {
            MovePlayer.isMoving = false;
            UpdateClock.timeMultiplier = 1;
        }
    }
}