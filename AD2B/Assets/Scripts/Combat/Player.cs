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
		id = "Player";
		weaponInHand = this.transform.GetChild(0);
		weapon = Resources.Load<Weapon>("Items/Weapons/M16");
		weaponInHand.GetComponent<Image>().sprite = weapon.image;
		primaryHolster.GetComponent<Image>().sprite = weapon.image;
		GetComponent<AudioSource>().clip = weapon.shot;
	}
}