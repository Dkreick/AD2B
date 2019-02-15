using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : MonoBehaviour {
    public static GameObject textArea;

    void Start () {
        textArea = GameObject.Find ("Area");
    }

    public static void AddText (string text) {
        textArea.GetComponent<Text> ().text += text;
    }
}