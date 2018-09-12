using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public List<Item> inventory = new List<Item>();

	void Start()
	{
		foreach (Item item in inventory)
		{
			//GameObject item = Resources.Load<Item>();

			//Resources.Load<Weapon>("Items/Weapons/M16");
		}
	}

	public void AddItem()
	{
		
	}	

	public void RemoveItem()
	{
		foreach (GameObject item in inventory)
		{
			//GameObject item = Resources.Load<Item>();
			//Resources.Load<Weapon>("Items/Weapons/M16");
		}
	}

	public void UseItem()
	{
		
	}
}