using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static string username = "Player";
    public static int level;
    public static int money;
    public static float experience;
    public static string charClass;

    public static string location;
    public static float travelSpeed;

    public static int health;
    public static int stamina;
    public static int adrenaline;

    public static float temperature;
    public static int hunger;
    public static int thirst;
    public static int sleep;
    public static int maxWeight;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        temperature = 37;
        hunger = 100;
        thirst = 100;
        sleep = 100;
        maxWeight = 10;

        health = 100;
        stamina = 100;
        travelSpeed = 10;
        money = 50;
        location = "BuenosAires";
    }
}