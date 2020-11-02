using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;

public class GroundCollide : MonoBehaviour
{
 
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Cat")
        {
            Destroy(target.gameObject);
            if (ScoreController.score!=0 && ScoreController.score != 20)
            {
                ScoreController.score--;
                ScoreController.playGame = false;
            }
        }
    }

}