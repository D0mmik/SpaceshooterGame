using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class ScoreManager : MonoBehaviour
{
  private ScoreData sd;
  void Awake()
  { 
    var json = PlayerPrefs.GetString("score", "{}");
    sd = JsonUtility.FromJson<ScoreData>(json);
  }
  public IEnumerable<Score> GetHighScores()
  {
    return sd.scores.OrderByDescending(x => x.score);
  }
  public void AddScore(Score score)
  {
    sd.scores.Add(score); 
  }
  private void OnDestroy()
  {
    SaveScore();
    //Debug.Log("saved");
  }
  public void SaveScore()
  {
    var json = JsonUtility.ToJson(sd);
    PlayerPrefs.SetString("score", json);
  }
  public void ScoreReset()
  {
    sd.scores.Clear();
  }
}


