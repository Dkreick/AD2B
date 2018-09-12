using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
	public GameObject itemToAdd;

	void Start()
	{
		foreach (Item item in PlayerData.inventory)
		{
			itemToAdd.GetComponent<Image>().sprite = item.iconImage;
			itemToAdd.GetComponent<Toggle>().group = GetComponent<ToggleGroup>();
			Instantiate(itemToAdd, transform);
		}
	}

	public void RemoveItem()
	{
		
	}

	public void UseItem()
	{

	}
}