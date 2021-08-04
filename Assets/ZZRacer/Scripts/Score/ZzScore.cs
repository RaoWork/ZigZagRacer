using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ZzScore
{

    // event
    public static EventHandler onScoreAmountUpdate;
    public static EventHandler onScoreBonusUpdate;


    private int score;

    public void ScoreAmoundAdd(int _score)
    {
        score += _score;
        if (onScoreAmountUpdate != null) onScoreAmountUpdate.Invoke(this, EventArgs.Empty);
    }

    public void ScoreBonus(int _score)
    {
        score += _score;
        if (onScoreBonusUpdate != null) onScoreBonusUpdate.Invoke(this, EventArgs.Empty);
    }

    public int GetScore()
    {
        return score;
    }
}
