using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterPlace : MonoBehaviour
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
}
