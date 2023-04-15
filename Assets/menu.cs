using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public GameObject StartScreen, LoadingScreen, LoadingScreenText;
    void Start()
    {
        LoadingScreen.SetActive(false);
        StartScreen.SetActive(true);
    }

    void Update()
    {
    }
    public void Start_button()
    {
        StartCoroutine(loadingscr());
    }

    public void quit_button()
    {
        Application.Quit();
    }

    IEnumerator loadingscr()
    {
        LoadingScreen.SetActive(true);
        StartScreen.SetActive(false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }
}
