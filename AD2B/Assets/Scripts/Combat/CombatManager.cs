using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float sliderValueSpeed;

    public Slider playerHealthBar;
    public Slider enemyHealthBar;
    public GameObject panelVictory;
    public GameObject panelDefeat;

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

        if (playerHealthBar.value <= 0)
        {
            panelDefeat.SetActive(true);
        }
        if (enemyHealthBar.value <= 0)
        {
            panelVictory.SetActive(true);
        }
    }

    IEnumerator ChangeSliderValue(Slider bar, float newValue)
    {
        float temp = bar.value - newValue / 100;
        while (bar.value > temp)
        {
            bar.value -= sliderValueSpeed * Time.deltaTime;
            yield return null;
        }
    }
}

