using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{

    public float ShowHeight = 5.653738f;
    public float HideHeight = 5.457f;
    private Vector3 myNewXYZPosition;
    public float speed = 1f;
    public float hideMoletimer = 1.5f;

    void Awake()
    {
        HideMole();

        transform.localPosition = myNewXYZPosition;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, myNewXYZPosition, Time.deltaTime * speed);

        

        hideMoletimer -= Time.deltaTime;
        if(hideMoletimer < 0)
        {
            HideMole();
        }
    }
    public void HideMole()
    {
        myNewXYZPosition = new Vector3(transform.localPosition.x, HideHeight, transform.localPosition.z);
    }

    public void ShowMole()
    {
        myNewXYZPosition = new Vector3(transform.localPosition.x, ShowHeight, transform.localPosition.z);

        hideMoletimer = 1.5f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hand"))
        {
            GameController.score++;
            HideMole();
        }
    }
}
