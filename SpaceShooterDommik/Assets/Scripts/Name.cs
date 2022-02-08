using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{   
    public TMP_InputField inputNick;
    public ScoreManager scoremanager;
    public void SubmitButton()
    {
        scoremanager.AddScore(new Score(inputNick.text,ScoreCounter.Score));
        SceneManager.LoadScene("Game");
    }
    public void CloseButton()
    {
       SceneManager.LoadScene("Game");
    }

}
