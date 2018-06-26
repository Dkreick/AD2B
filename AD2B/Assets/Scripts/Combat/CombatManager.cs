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
        StartCoroutine(ChangeSliderValue(enemyHealthBar, totalDamage, "Enemy"));

        if (enemyHealthBar.value <= 0)
        {
            panelVictory.SetActive(true);
        }
    }

    void MakeNextTurn(string author)
    {
        if (author == "Player")
        {
            return;
        }
        else
        {
            if (enemyHealthBar.value * 100 > 50)
            {
                float totalDamage = 10;
                StartCoroutine(ChangeSliderValue(playerHealthBar, totalDamage, "Player"));

                if (playerHealthBar.value <= 0)
                {
                    panelDefeat.SetActive(true);
                }
            }

            if (enemyHealthBar.value * 100 < 25)
            {
                
            }
            else
            {
                int chance = Random.Range(0, 1);

                if (chance == 1)
                {
                    float totalDamage = 10;
                    StartCoroutine(ChangeSliderValue(playerHealthBar, totalDamage, "Player"));

                    if (playerHealthBar.value <= 0)
                    {
                        panelDefeat.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Enemy is taking cover");
                }
            }
        }
    }

    IEnumerator ChangeSliderValue(Slider bar, float newValue, string target)
    {
        float temp = bar.value - newValue / 100;
        while (bar.value > temp)
        {
            bar.value -= sliderValueSpeed * Time.deltaTime;
            yield return null;
        }

        MakeNextTurn(target);
    }
}