using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    public void LoadScene(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
        ScoreManager.score = 0;
    }
}
