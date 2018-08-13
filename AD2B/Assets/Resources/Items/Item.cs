using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
	private GameObject itemPrefab;
	[SerializeField] string id;
	[SerializeField] string type;
	[SerializeField] string description;
	[SerializeField] float weight;
	public Sprite image;

	public GameObject GetWeaponPrefab()
	{
		return itemPrefab;
	}
}