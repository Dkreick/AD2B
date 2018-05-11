using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 target;
    public float speed;
    public static bool isMoving;

    void OnMouseDown()
    {
        isMoving = true;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.transform.LookAt(target, Vector3.forward);
        target.z = transform.position.z;
    }

    void Update()
    {
        if (isMoving)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, target, speed * Time.deltaTime);

        }

        if (player.transform.position == target)
        {
            isMoving = false;
        }
    }
}
