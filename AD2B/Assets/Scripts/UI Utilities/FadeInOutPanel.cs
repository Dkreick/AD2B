using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOutPanel : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    public float secondsToTriggerFade;
    public float secondsToCompleteFade;

    void Start()
    {
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
    }

    public void Enable()
    {
        gameObject.SetActive(true);
        StartCoroutine("FadeIn");
    }

    public void Disable()
    {
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(secondsToTriggerFade);
        canvasGroup.interactable = false;
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / secondsToCompleteFade;
            yield return null;
        }
        canvasGroup.interactable = true;
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(secondsToTriggerFade / 2);
        canvasGroup.interactable = false;
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / secondsToCompleteFade;
            yield return null;
        }
        gameObject.SetActive(false);
    }
}