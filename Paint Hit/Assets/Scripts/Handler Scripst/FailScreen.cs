using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailScreen : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject failScreen;


    public void HomeScreenOpen()
    {
        failScreen.SetActive(false);
        homeScreen.SetActive(true);
    }
}
