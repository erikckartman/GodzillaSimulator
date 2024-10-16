using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Building"))
        {
            score = score + 150;
        }
        else if (collision.gameObject.CompareTag("Lidl"))
        {
            score = score + 500;
        }
            scoreText.text = "SCORE: " + score.ToString();
    }
}
