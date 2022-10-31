using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{

    public static ColorScript instance;

    public Color[] color1;
    public Color[] color2;
    public Color[] color3;

    public static Color[] colorArray;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if(instance != null)
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        ChangeColor();
    }

    public void ChangeColor()
    {
        int randomC = Random.Range(0, 3);

        print(randomC);

        PlayerPrefs.SetInt("ColorSelect", randomC);
        PlayerPrefs.GetInt("ColorSelect");

        if (PlayerPrefs.GetInt("ColorSelect") == 0)
            colorArray = color1;

        if (PlayerPrefs.GetInt("ColorSelect") == 1)
            colorArray = color2;

        if (PlayerPrefs.GetInt("ColorSelect") == 2)
            colorArray = color3;
    }


}
