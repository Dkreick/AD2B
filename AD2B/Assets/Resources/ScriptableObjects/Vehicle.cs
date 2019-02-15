using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = ("Item/Vehicle"))]
public class Vehicle : Item {
    [SerializeField] int speed;
    [SerializeField] int durability;
    [SerializeField] int range;
    [SerializeField] int trunkCapacity;
    [SerializeField] float fightRisk;
}