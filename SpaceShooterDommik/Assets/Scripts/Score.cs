using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Score
{
    public string playername;
    public float score;
    public Score(string playername, float score)
    {
        this.playername = playername;
        this.score = score;
    }
}
