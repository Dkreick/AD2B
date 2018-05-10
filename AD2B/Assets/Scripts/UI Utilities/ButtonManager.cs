using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    private string _url;

    public void OpenURL(string _url)
    {
        Application.OpenURL(_url);
    }

    public void ChangeToggleColor(string className)
    {
        if (GetComponent<Toggle>().isOn)
        {
            GetComponent<Image>().color = Color.red;
            PlayerData.charClass = className;
        }
        else
        {
            GetComponent<Image>().color = Color.white;
        }            
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
