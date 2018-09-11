using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public List<ScriptableObject> inventory = new List<ScriptableObject>();
	//[SerializeObject] GameObject inventoryGrid;

	void Start()
	{
		foreach (ScriptableObject item in inventory)
		{
			GameObject item = Resources.Loa
		}
	}

	public void AddItem()
	{
		
	}	

	public void RemoveItem()
	{

	}
}