using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int Score = 0;
    public TMP_Text ScoreText;
    public TMP_Text HighScoreText;

    void Start()
    {
        Score = 0;
    }
    void Update()
    {
      ScoreText.text = Score.ToString();
    }
}
