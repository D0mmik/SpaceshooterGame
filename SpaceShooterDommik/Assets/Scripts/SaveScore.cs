using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SaveScore : MonoBehaviour
{   
    public TMP_Text HighScoreText;
    public ScoreManager scoreManager;
    public GameObject nickname;
    public GameObject deathscreen;
    public ScoreCounter scorecounter;
    
    void Start()
    {   
        if(ScoreCounter.Score >= PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", ScoreCounter.Score);
            nickname.SetActive(true);
            deathscreen.SetActive(false);
        }
        HighScoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
}
