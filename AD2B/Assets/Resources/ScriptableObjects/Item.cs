using System.Collections;
using UnityEngine;

public class Item : ScriptableObject {
    [SerializeField] string id;
    [SerializeField] string type;
    [SerializeField] string description;
    public float weight;
    public Sprite image;
    public Sprite iconImage;
}