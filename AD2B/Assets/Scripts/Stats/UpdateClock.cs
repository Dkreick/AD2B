using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateClock : MonoBehaviour {
    private int minutes;
    private int hours;
    public static int timeMultiplier;
    public Text textClock;

    void Start () {
        textClock = gameObject.GetComponent<Text> ();
        hours = 8;
        minutes = 0;
        timeMultiplier = 1;
        textClock.text = hours.ToString ("00") + ":" + minutes.ToString ("00");
        Invoke ("SetClock", 0f);
    }

    void SetClock () {
        if (minutes >= 60) {
            minutes = 0;
            hours += 1;
        }
        if (hours >= 24) {
            hours = 0;
        }

        minutes += 1;
        textClock.text = "Time " + hours.ToString ("00") + ":" + minutes.ToString ("00");
        Invoke ("SetClock", 1f / timeMultiplier);
    }
}