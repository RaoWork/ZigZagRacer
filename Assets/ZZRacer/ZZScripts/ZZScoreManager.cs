using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZScoreManager : MonoBehaviour
{

    [SerializeField] private int score;
    private float time = 1f;

    Coroutine updateScore = null;


    void Start()
    {
    }

    void Update()
    {
    }

    public void ScoreAdd()
    {
        updateScore = StartCoroutine(UpdateScoreAmount());
    }

    public void ScoreStop()
    {
        StopCoroutine(updateScore);
    }


    IEnumerator UpdateScoreAmount()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            ScoreUpdate(1);
        }
    }

    void ScoreUpdate(int _score)
    {
        score += _score;
    }

    public void ScoreBonus(int _score)
    {
        score += _score;
    }
}