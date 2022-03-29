using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public GameObject dart;
    public TextMeshProUGUI text;

    GameObject script = GameObject.Find("ScriptObject");

    void Start()
    {
        ResetFunction resetFunction = script.GetComponent<ResetFunction>();
    }

    void OnCollisionEnter(Collision dataFromCollision)
    {
        ResetFunction resetFunction = script.GetComponent<ResetFunction>();
        if (resetFunction.targetHit == false) { 
            if (dataFromCollision.gameObject.name == "1")
            {
                text.text = "1";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "2")
            {
                text.text = "2";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "3")
            {
                text.text = "3";
                resetFunction.targetHit = true;
            }
    
            if (dataFromCollision.gameObject.name == "4")
            {
                text.text = "4";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "5")
            {
                text.text = "5";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "6")
            {
                text.text = "6";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "7")
            {
                text.text = "7";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "8")
            {
                text.text = "8";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "9")
            {
                text.text = "9";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "10")
            {
                text.text = "10";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "11")
            {
                text.text = "11";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "12")
            {
                text.text = "12";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "13")
            {
                text.text = "13";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "14")
            {
                text.text = "14";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "15")
            {
                text.text = "15";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "16")
            {
                text.text = "16";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "17")
            {
                text.text = "17";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "18")
            {
                text.text = "18";
                resetFunction.targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "19")
            {
                text.text = "19";
                resetFunction.targetHit = true;
            }
  
            if (dataFromCollision.gameObject.name == "20")
            {
                text.text = "20";
                resetFunction.targetHit = true;
            }
        }
    }
}
