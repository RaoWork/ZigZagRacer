using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZScoreManager : MonoBehaviour
{

    public ZzScore zzScore;

    private float time = 0.2f;
    Coroutine updateScore = null;


    private void Awake()
    {
        zzScore = new ZzScore();
    }

    public void ScoreStarted()
    {
        if (updateScore != null)
            StopCoroutine(updateScore);

        updateScore = StartCoroutine(UpdateScoreAmount());
    }

    public void ScoreStoped()
    {
        if (updateScore != null)
            StopCoroutine(updateScore);
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