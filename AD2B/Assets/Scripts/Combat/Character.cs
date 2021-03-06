using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {
    public Slider healthBar;
    public Slider staminaBar;
    public Slider adrenalineBar;

    public string id;
    public float health;
    public float stamina;
    public float adrenaline;
    public float defense;

    protected Weapon weapon;
    protected Transform weaponInHand;

    public float CalculateDamage () {
        if (Random.Range (0, 1) <= weapon.accuracy) {
            return Random.Range (weapon.minDamage, weapon.maxDamage);
        } else {
            return 0;
        }
    }
}