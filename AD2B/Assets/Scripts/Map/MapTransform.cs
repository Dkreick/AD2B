using UnityEngine;

public class MapTransform : MonoBehaviour
{
    public float minScale;
    public float maxScale;
    public float amountToScale;
    public bool isHovered;
    private Transform map;

    void Start()
    {
        map = gameObject.transform.GetChild(0);
    }

    void Update()
    {
        if (isHovered)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                Vector3 scale = map.localScale;
                scale.x += amountToScale;
                scale.y += amountToScale;
                map.localScale = scale;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Vector3 scale = map.localScale;
                scale.x -= amountToScale;
                scale.y -= amountToScale;
                map.localScale = scale;
            }

            map.localScale = new Vector3(
                Mathf.Clamp(map.localScale.x, minScale, maxScale),
                Mathf.Clamp(map.localScale.y, minScale, maxScale),
                Mathf.Clamp(map.localScale.z, minScale, maxScale)
            );
        }
    }

    public void ChangeStatus(bool value)
    {
        isHovered = value;
    }

    public void DragMap()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseMovement = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 1);
            map.position += mouseMovement;
        }
    }
}