using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Item/Weapon"))]
public class Weapon : ScriptableObject
{
	[SerializeField] GameObject weaponPrefab;
	[SerializeField] string id;
	[SerializeField] string type;
	[SerializeField] string description;
	[SerializeField] int minDamage;
	[SerializeField] int maxDamage;
	[SerializeField] int accuracy;
	[SerializeField] float staminaCost;
	[SerializeField] int capacity;
	[SerializeField] float weight;
	[SerializeField] string ammoUsed;
	public Sprite image;

	public GameObject GetWeaponPrefab()
	{
		return weaponPrefab;
	}
}