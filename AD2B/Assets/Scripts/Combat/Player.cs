using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
	public GameObject primaryHolster;
	public GameObject secondaryHolster;

	void Start()
	{
		id = PlayerData.username;
		weaponInHand = this.transform.GetChild(0);
		weapon = Resources.Load<Weapon>("ScriptableObjects/Weapons/M16");
		weaponInHand.GetComponent<Image>().sprite = weapon.image;
		primaryHolster.GetComponent<Image>().sprite = weapon.image;
		GetComponent<AudioSource>().clip = weapon.shot;
	}
}