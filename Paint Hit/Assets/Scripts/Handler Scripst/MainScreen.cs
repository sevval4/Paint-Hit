using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScreen : MonoBehaviour
{

    public Text levelText;
    

    private void OnEnable()
    {
        levelText.text = " " +PlayerPrefs.GetInt("C_Level", 1) + string.Empty;
    }

}
