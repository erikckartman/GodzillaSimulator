using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Results : MonoBehaviour
{
    public TextMeshProUGUI st;
    public TextMeshProUGUI hst;
    public static int highscore = 0;

    void Update()
    {
        if (ScoreManager.score >= highscore)
        {
            highscore = ScoreManager.score;
        }

        st.text = "SCORE: " + ScoreManager.score.ToString();
        hst.text = "HIGHSCORE: " + highscore.ToString();
    }
}
