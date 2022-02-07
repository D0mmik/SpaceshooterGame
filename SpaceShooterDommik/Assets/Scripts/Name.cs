using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{   
    public TMP_InputField inputNick;
    public ScoreManager scoremanager;
    public ScoreCounter scorecounter;
    public void SubmitButton()
    {
        scoremanager.AddScore(new Score(inputNick.text,ScoreCounter.Score));
    }
    public void CloseButton()
    {
       SceneManager.LoadScene("Game");
    }

}
