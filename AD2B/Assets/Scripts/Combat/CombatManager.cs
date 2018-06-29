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

    public float playerDefense;
    public float enemyDefense;

    void Start()
    {
        playerDefense = 1;
        enemyDefense = 1;
    }

    public void Cover(string author)
    {
        if (author == "Player")
        {
            playerDefense = 0.5f;
            MakeNextTurn("Enemy");
        }
        if (author == "Enemy")
        {
            enemyDefense = 0.5f;
            MakeNextTurn("Player");
        }
    }

    public void Inventory()
    {

    }

    public void Attack()
    {
        float totalDamage = 10 * enemyDefense;
        StartCoroutine(ChangeSliderValue(enemyHealthBar, totalDamage, "Enemy"));
        enemyDefense = 1;
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
                float totalDamage = 10 * playerDefense;
                StartCoroutine(ChangeSliderValue(playerHealthBar, totalDamage, "Player"));
                playerDefense = 1;
                if (playerHealthBar.value <= 0)
                {
                    panelDefeat.SetActive(true);
                }
            }

            if (enemyHealthBar.value * 100 < 25)
            {
                Cover("Enemy");
            }
            else
            {
                int chance = Random.Range(0, 1);

                if (chance == 1)
                {
                    float totalDamage = 10 * playerDefense;
                    StartCoroutine(ChangeSliderValue(playerHealthBar, totalDamage, "Player"));
                    playerDefense = 1;
                    if (playerHealthBar.value <= 0)
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