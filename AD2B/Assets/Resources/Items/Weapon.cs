using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Item/Weapon"))]
public class Weapon : Item
{
	[SerializeField] int minDamage;
	[SerializeField] int maxDamage;
	[SerializeField] int accuracy;
	[SerializeField] float staminaCost;
	[SerializeField] int capacity;
	[SerializeField] string ammoUsed;
}