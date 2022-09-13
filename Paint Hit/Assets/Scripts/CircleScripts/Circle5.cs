using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle5 : MonoBehaviour
{

    void Start()
    {
        iTween.MoveTo(base.gameObject, iTween.Hash(new object[]
        {
            "y",
            0,
            "easetype",
            iTween.EaseType.easeInOutQuad,
            "time",
            0.6,
            "OnComplete",
            "rotatecircle",

        }));
    }

    void RotateCircle()
    {
        iTween.RotateBy(base.gameObject, iTween.Hash(new object[]
        {
            "y",
            1f,
            "time",
            BallHandler.rotationTime,
            "easeType",
            iTween.EaseType.easeInOutQuad,
            "loopType",
            iTween.LoopType.pingPong,
            "delay",
            1
        }));
    }

}
