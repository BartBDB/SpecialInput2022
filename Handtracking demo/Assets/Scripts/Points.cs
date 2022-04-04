using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public GameObject dart;
    public TextMeshProUGUI text;
    public bool targetHit = false;

    public void ResetDart()
    {
        GameObject cube = GameObject.Find("Cube");
        cube.transform.position = new Vector3(0, 1, 0.56f);
        cube.transform.rotation = new Quaternion(0, 0, 0, 0);
        text.text = "";
        targetHit = false;
    }

    void OnCollisionEnter(Collision dataFromCollision)
    {
        if (targetHit == false) { 
            if (dataFromCollision.gameObject.name == "1")
            {
                text.text = "1";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "2")
            {
                text.text = "2";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "3")
            {
                text.text = "3";
                targetHit = true;
            }
    
            if (dataFromCollision.gameObject.name == "4")
            {
                text.text = "4";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "5")
            {
                text.text = "5";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "6")
            {
                text.text = "6";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "7")
            {
                text.text = "7";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "8")
            {
                text.text = "8";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "9")
            {
                text.text = "9";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "10")
            {
                text.text = "10";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "11")
            {
                text.text = "11";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "12")
            {
                text.text = "12";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "13")
            {
                text.text = "13";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "14")
            {
                text.text = "14";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "15")
            {
                text.text = "15";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "16")
            {
                text.text = "16";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "17")
            {
                text.text = "17";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "18")
            {
                text.text = "18";
                targetHit = true;
            }

            if (dataFromCollision.gameObject.name == "19")
            {
                text.text = "19";
                targetHit = true;
            }
  
            if (dataFromCollision.gameObject.name == "20")
            {
                text.text = "20";
                targetHit = true;
            }
        }
    }
}