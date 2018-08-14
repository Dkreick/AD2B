using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Slider healthBar;
    public Slider staminaBar;
    public Slider adrenalineBar;

    private float health;
    private float stamina;
    private float adrenaline;
    public float defense;
    
	protected Weapon weapon;
    protected Transform weaponInHand;
}