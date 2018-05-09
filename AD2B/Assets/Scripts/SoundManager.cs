using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public float secondsBeforePlay;
    private bool play;
    private float musicVolume;
    private float fxVolume;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

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
