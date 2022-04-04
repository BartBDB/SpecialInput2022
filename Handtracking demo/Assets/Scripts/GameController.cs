using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMesh timerText;
    public float gameTimer = 90f; //time Gametimer

    public GameObject moleContainer;
    private Mole[] moles;
    public float showMoletimer = 1.5f;

    public TextMesh scoreText;
    public static int score;

    void Start()
    {
        moles = moleContainer.GetComponentsInChildren<Mole>();

        Debug.Log("Number of Moles " + moles.Length);
    }

    private void Update()
    {
        gameTimer -= Time.deltaTime;
        scoreText.text = score.ToString();

        scoreText.text = "Score: " + score;

        if (gameTimer >= 0f)
        {
            timerText.text = "Time Left: " + Mathf.Floor(gameTimer) + " s";

            showMoletimer -= Time.deltaTime;
            if(showMoletimer < 0f)
            {
                moles[Random.Range(0, moles.Length)].ShowMole();

                showMoletimer = 1.5f;
            }
        }
        else
        {
            timerText.text = "Game Over";
        }
    }
}
