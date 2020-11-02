using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public static bool playGame = true;
    public Text endScreen;
    public Text ScoreText;
    public static int score = 1;

    void Start()
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        ScoreText.text = "Score: " + score.ToString();
        if (score == 0)
        {
            endScreen.text = "YOU LOSE";
        }
        else if (score==20)
        {
            endScreen.text = "YOU WON";
        }


    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag=="Cat")
        {
            Destroy(target.gameObject);
            if(score<20)
            {
                score++;
            }
        }
    }

}
/*
void OnTriggerEnter2D(Collider2D target)
{
    if (target.gameObject.tag == "Player")
    {
        Destroy(cat);
        score++;
    }
    if (target.gameObject.tag == "Finish")
    {
        Destroy(cat);
        score--;
    }
}
*/