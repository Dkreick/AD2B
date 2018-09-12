using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Item/Weapon"))]
public class Weapon : Item
{
	public int minDamage;
	public int maxDamage;
	public int accuracy;
	[SerializeField] float staminaCost;
	[SerializeField] int capacity;
	[SerializeField] string ammoUsed;
	public AudioClip shot;
}