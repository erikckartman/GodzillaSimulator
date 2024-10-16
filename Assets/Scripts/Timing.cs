using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timing : MonoBehaviour
{
    private float time = 200;
    public TextMeshProUGUI timer;

    void Update()
    {
        time -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(time);
        timer.text = "TIMER: " + seconds.ToString();

        if (time <= 1)
        {
            Application.LoadLevel("Resault");
        }
    }
}
