﻿using UnityEngine;

public class MapTransform : MonoBehaviour
{
    public float minScale;
    public float maxScale;
    public float amountToScale;
    public bool isHovered;

    void Update()
    {
        if (isHovered)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                Vector3 scale = transform.localScale;
                scale.x += amountToScale;
                scale.y += amountToScale;
                transform.localScale = scale;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Vector3 scale = transform.localScale;
                scale.x -= amountToScale;
                scale.y -= amountToScale;
                transform.localScale = scale;
            }
            transform.localScale = new Vector3(
                Mathf.Clamp(transform.localScale.x, minScale, maxScale),
                Mathf.Clamp(transform.localScale.y, minScale, maxScale),
                Mathf.Clamp(transform.localScale.z, minScale, maxScale)
            );
        }
    }

    public void ChangeStatus(bool value)
    {
        isHovered = value;
    }
}