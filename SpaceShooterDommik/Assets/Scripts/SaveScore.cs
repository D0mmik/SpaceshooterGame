﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveScore : MonoBehaviour
{   
    public TMP_Text HighScoreText;
    void Start()
    {   
        if(ScoreCounter.Score >= PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", ScoreCounter.Score);
        }
        HighScoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
}
