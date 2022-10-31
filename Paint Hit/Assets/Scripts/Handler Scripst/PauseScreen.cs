using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject pauseScreen;
    public GameObject startScreen;


    public void HomeScreenOpen()
    {
        pauseScreen.SetActive(false);
        homeScreen.SetActive(true);
    }

    public void PauseScreenOpen()
    {
        homeScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }
    public void StartScreen()
    {
        homeScreen.SetActive(false);
        pauseScreen.SetActive(false);
        startScreen.SetActive(true);
    }
}
