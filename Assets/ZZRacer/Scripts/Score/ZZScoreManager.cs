using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZScoreManager : MonoBehaviour
{


    public ZzScore zzScore;

    private float time = 0.2f;
    Coroutine CorUpdatedScore = null;


    private void Awake()
    {
        zzScore = new ZzScore();
    }

    public void ScoreStarted()
    {
        if (CorUpdatedScore != null)
            StopCoroutine(CorUpdatedScore);

        CorUpdatedScore = StartCoroutine(UpdateScoreAmount());
    }

    public void ScoreStoped()
    {
        if (CorUpdatedScore != null)
            StopCoroutine(CorUpdatedScore);
    }

    IEnumerator UpdateScoreAmount()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            zzScore.ScoreAmoundAdd(1);
        }
    }
}