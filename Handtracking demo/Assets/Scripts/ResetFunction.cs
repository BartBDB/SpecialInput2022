using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFunction : MonoBehaviour
{
    public void ResetDart()
    {
        GameObject cube = GameObject.Find("Cube");
        cube.transform.position = new Vector3(0, 1, 0.56f);
    }
}
