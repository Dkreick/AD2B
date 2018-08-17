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

    public void Cover()
    {

    }

    public void Attack()
    {
        float totalDamage = player.CalculateDamage() - enemy.defense;
        StartCoroutine(ChangeSliderValue(enemy.healthBar, totalDamage, "Enemy"));
        player.GetComponent<AudioSource>().Play();
        ConsoleManager.AddText(enemy.id + " was wounded for " + totalDamage + "\n");
        transform.GetChild(2).GetComponent<Button>().interactable = false;
        if (enemy.healthBar.value <= 0)
        {
            panelVictory.SetActive(true);
        }
    }

    void ManageEnemyTurn()
    {
        if (enemy.healthBar.value * 100 > 50)
        {
            float totalDamage = enemy.CalculateDamage() - player.defense;
            StartCoroutine(ChangeSliderValue(player.healthBar, totalDamage, "Player"));
            enemy.GetComponent<AudioSource>().Play();
            ConsoleManager.AddText(player.id + " was wounded for " + totalDamage + "\n");
            if (player.healthBar.value <= 0)
            {
                panelDefeat.SetActive(true);
            }
        }

        if (enemy.healthBar.value * 100 < 25)
        {
            //Cover("Enemy");
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
                //Cover("Enemy");
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

        if (target == "Player")
        {
            transform.GetChild(2).GetComponent<Button>().interactable = true;
        }
        else
        {
            ManageEnemyTurn();
        }
    }
}