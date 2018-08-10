using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatManager : MonoBehaviour
{    
    public float sliderValueSpeed;
    
    public Player player;
    public Enemy enemy;
    public GameObject panelVictory;
    public GameObject panelDefeat;

    public void Cover(string author)
    {
        if (author == "Player")
        {
            MakeNextTurn("Enemy");
        }
        if (author == "Enemy")
        {
            MakeNextTurn("Player");
        }
    }

    public void Inventory()
    {

    }

    public void Attack()
    {
        float totalDamage = player.damage - enemy.defense;
        StartCoroutine(ChangeSliderValue(enemy.healthBar, totalDamage, "Enemy"));
        enemy.defense = 1;
        if (enemy.healthBar.value <= 0)
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
            if (enemy.healthBar.value * 100 > 50)
            {
                float totalDamage = enemy.damage - player.defense;
                StartCoroutine(ChangeSliderValue(player.healthBar, totalDamage, "Player"));
                if (player.healthBar.value <= 0)
                {
                    panelDefeat.SetActive(true);
                }
            }

            if (enemy.healthBar.value * 100 < 25)
            {
                Cover("Enemy");
            }
            else
            {
                int chance = Random.Range(0, 1);

                if (chance == 1)
                {
                    float totalDamage = 10 - player.defense;
                    StartCoroutine(ChangeSliderValue(player.healthBar, totalDamage, "Player"));
                    if (player.healthBar.value <= 0)
                    {
                        panelDefeat.SetActive(true);
                    }
                }
                else
                {
                    Cover("Enemy");
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