using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float sliderValueSpeed;
    public Slider enemyHealthBar;
    public Slider enemyStaminaBar;
    public Slider enemyAdrenalineBar;

    public void Cover()
    {

    }

    public void Inventory()
    {

    }

    public void Attack()
    {
        float totalDamage = 10;
        StartCoroutine(ChangeSliderValue(enemyHealthBar, totalDamage));
    }

    IEnumerator ChangeSliderValue(Slider bar, float newValue)
    {
        
        float temp = bar.value - newValue / 100;
        print(temp);
        while (bar.value > temp)
        {
            bar.value -= sliderValueSpeed * Time.deltaTime;
            yield return null;
        }
    }
}
