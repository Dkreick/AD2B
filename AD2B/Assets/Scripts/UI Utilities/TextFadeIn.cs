using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour {
    private CanvasGroup canvasGroup;
    public float secondsToTriggerFade;
    public float secondsToCompleteFade;

    void Start () {
        canvasGroup = gameObject.GetComponent<CanvasGroup> ();

        StartCoroutine ("FadeIn");
    }

    IEnumerator FadeIn () {
        yield return new WaitForSeconds (secondsToTriggerFade);
        while (canvasGroup.alpha < 1) {
            canvasGroup.alpha += Time.deltaTime / secondsToCompleteFade;
            yield return null;
        }
        canvasGroup.interactable = true;
    }
}