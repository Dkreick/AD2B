using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlace : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("CHOCOCHOCOCHOCOCHOCO");
        MovePlayer.isMoving = false;
    }
}
