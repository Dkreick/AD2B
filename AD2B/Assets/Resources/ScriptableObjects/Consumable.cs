using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = ("Item/Consumable"))]
public class Consumable : Item {
    [SerializeField] float hungerRestored;
    [SerializeField] float thirstRestored;
    [SerializeField] float sleepRestored;
    [SerializeField] float healthRestored;
    [SerializeField] float staminaRestored;
    [SerializeField] float adrenalineRestored;
}