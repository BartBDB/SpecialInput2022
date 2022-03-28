using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public GameObject dart;
    public TextMeshPro text;

    void Start()
    {
        text.text = "";
    }
    void OnCollisionEnter(Collision dataFromCollision)
    {
        if (dataFromCollision.gameObject.name == "1")
        {
            text.text = "1";
        }

        if (dataFromCollision.gameObject.name == "2")
        {
            text.text = "2";
        }

        if (dataFromCollision.gameObject.name == "3")
        {
            text.text = "3";
        }

        if (dataFromCollision.gameObject.name == "4")
        {
            text.text = "4";
        }

        if (dataFromCollision.gameObject.name == "5")
        {
            text.text = "5";
        }

        if (dataFromCollision.gameObject.name == "6")
        {
            text.text = "6";
        }

        if (dataFromCollision.gameObject.name == "7")
        {
            text.text = "7";
        }

        if (dataFromCollision.gameObject.name == "8")
        {
            text.text = "8";
        }

        if (dataFromCollision.gameObject.name == "9")
        {
            text.text = "9";
        }

        if (dataFromCollision.gameObject.name == "10")
        {
            text.text = "10";
        }

        if (dataFromCollision.gameObject.name == "11")
        {
            text.text = "11";
        }

        if (dataFromCollision.gameObject.name == "12")
        {
            text.text = "12";
        }

        if (dataFromCollision.gameObject.name == "13")
        {
            text.text = "13";
        }

        if (dataFromCollision.gameObject.name == "14")
        {
            text.text = "14";
        }

        if (dataFromCollision.gameObject.name == "15")
        {
            text.text = "15";
        }

        if (dataFromCollision.gameObject.name == "16")
        {
            text.text = "16";
        }

        if (dataFromCollision.gameObject.name == "17")
        {
            text.text = "17";
        }

        if (dataFromCollision.gameObject.name == "18")
        {
            text.text = "18";
        }

        if (dataFromCollision.gameObject.name == "19")
        {
            text.text = "19";
        }

        if (dataFromCollision.gameObject.name == "20")
        {
            text.text = "20";
        }
    }
}
