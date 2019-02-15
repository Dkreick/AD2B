using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character {
    void Start () {
        id = "Enemy";

        //GET A RANDOM WEAPON
        Object[] weapons;
        weaponInHand = this.transform.GetChild (0);
        weapons = Resources.LoadAll ("ScriptableObjects/Weapons", typeof (Weapon));
        weapon = (Weapon) weapons[Random.Range (0, weapons.Length)];

        weaponInHand.GetComponent<Image> ().sprite = weapon.image;
        GetComponent<AudioSource> ().clip = weapon.shot;
    }
}