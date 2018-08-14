using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
	void Start()
	{
		weaponInHand = this.transform.GetChild(0);
		weapon = Resources.Load<Weapon>("Items/Weapons/M16");
		weaponInHand.GetComponent<Image>().sprite = weapon.image;
		GetComponent<AudioSource>().clip = weapon.shot;
	}

	public float CalculateDamage()
	{
		return Random.Range(weapon.minDamage, weapon.maxDamage);
	}
}