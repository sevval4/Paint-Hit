using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsHandlerScript : MonoBehaviour
{

    public static int currentLevel;

    public static int ballsCount;

    public static int totalCircles;

    public static Color currentColor;

    void Awake()
    {
        if (PlayerPrefs.GetInt("firstTime12", 0) == 0)
        {
            PlayerPrefs.SetInt("firstTime12", 1);
            PlayerPrefs.SetInt("C_Level", 1);
            //Add more to it 
        }
        UpgradeLevel();
    }

    public void UpgradeLevel()
    {
        currentLevel = PlayerPrefs.GetInt("C_Level", 1);

        if (currentLevel >= 1 && currentLevel < 3)
        {
            ballsCount = 3;
            totalCircles = 2;
        }

        if (currentLevel >= 3 && currentLevel < 5)
        {
            ballsCount = 4;
            totalCircles = 3;
            BallHandler.rotationSpeed = 110;
            BallHandler.rotationTime = 2;
        }

        if (currentLevel >= 5 && currentLevel < 8)
        {
            ballsCount = 5;
            totalCircles = 4;
            BallHandler.rotationSpeed = 120;
            BallHandler.rotationTime = 2;
        }

        if (currentLevel >= 8 && currentLevel < 11)
        {
            ballsCount = 6;
            totalCircles = 5;
            BallHandler.rotationSpeed = 130;
            BallHandler.rotationTime = 2;
        }

        if (currentLevel >= 11 && currentLevel < 14)
        {
            ballsCount = 7;
            totalCircles = 6;
            BallHandler.rotationSpeed = 140;
            BallHandler.rotationTime = 2;
        }

        if (currentLevel >= 14 && currentLevel < 18)
        {
            ballsCount = 8;
            totalCircles = 7;
            BallHandler.rotationSpeed = 150;
            BallHandler.rotationTime = 2;
        }
        if (currentLevel >= 18 && currentLevel < 22)
        {
            ballsCount = 8;
            totalCircles = 7;
            BallHandler.rotationSpeed = 160;
            BallHandler.rotationTime = 2;
        }
        if (currentLevel >= 22 && currentLevel < 24)
        {
            ballsCount = 8;
            totalCircles = 7;
            BallHandler.rotationSpeed = 160;
            BallHandler.rotationTime = 1;
        }

        if (currentLevel >= 24)
        {
            ballsCount =9;
            totalCircles = 7;
            BallHandler.rotationSpeed = 170;
            BallHandler.rotationTime = 1;
        }

    }

    public void MakeHurdles1()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int index = Random.Range(1, 3);

        gameObject.transform.GetChild(index).gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.transform.GetChild(index).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
        gameObject.transform.GetChild(index).gameObject.tag = "red";
    }

    public void MakeHurdles2()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1,3),
            Random.Range(15,17)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }

    public void MakeHurdles3()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1,3),
            Random.Range(4,6),
            Random.Range(18,20)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }

    public void MakeHurdles4()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1,3),
            Random.Range(4,6),
            Random.Range(15, 17),
            Random.Range(22, 24)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }

    public void MakeHurdles5()
    {
        GameObject gameObject = GameObject.Find("Circle" + BallHandler.currentCircleNo);

        int[] array = new int[]
        {
            Random.Range(1,3),
            Random.Range(4,6),
            Random.Range(11, 13),
            Random.Range(8, 10),
            Random.Range(15, 17)
        };

        for (int i = 0; i < array.Length; i++)
        {
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.transform.GetChild(array[i]).gameObject.GetComponent<MeshRenderer>().material.color = currentColor;
            gameObject.transform.GetChild(array[i]).gameObject.tag = "red";
        }

    }

}
