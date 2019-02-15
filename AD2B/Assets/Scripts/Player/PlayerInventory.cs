using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour {
    public GameObject itemToAdd;
    private float currentWeight;
    public GameObject textWeight;

    void Start () {
        foreach (Item item in PlayerData.inventory) {
            itemToAdd.GetComponent<Image> ().sprite = item.iconImage;
            itemToAdd.GetComponent<Toggle> ().group = GetComponent<ToggleGroup> ();
            Debug.Log (item.weight);
            currentWeight += item.weight;

            Instantiate (itemToAdd, transform);
        }

        textWeight.GetComponent<Text> ().text = "Weight: " + currentWeight + "Kg";
    }

    public void RemoveItem () {

    }

    public void UseItem () {

    }
}