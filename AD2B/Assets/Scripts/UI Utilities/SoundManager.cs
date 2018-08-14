using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public float secondsBeforePlay;
    private bool play;
    private float musicVolume;
    private float fxVolume;

    void Start()
    {
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(secondsBeforePlay);
        GetComponent<AudioSource>().Play();
    }
}