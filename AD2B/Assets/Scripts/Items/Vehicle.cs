using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Item/Vehicle"))]
public class Vehicle : ScriptableObject
{
	[SerializeField] GameObject weaponPrefab;
	[SerializeField] string id;
	[SerializeField] string description;
	[SerializeField] int speed;
	[SerializeField] int durability;
	[SerializeField] int range;
	[SerializeField] int trunkCapacity;
	[SerializeField] float fightRisk;
	[SerializeField] Sprite image;

	public GameObject GetWeaponPrefab()
	{
		return weaponPrefab;
	}
}