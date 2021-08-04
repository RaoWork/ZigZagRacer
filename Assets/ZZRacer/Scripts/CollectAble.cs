using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAble : MonoBehaviour
{

    [SerializeField] string playerTagName;


    void Start()
    {
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == playerTagName)
        {
            PlayCollectSound();

            GameObject.FindObjectOfType<ZZScoreManager>().zzScore.ScoreBonus(10);
            Destroy(gameObject, 0f);
        }
    }

    void PlayCollectSound()
    {
        if (GameObject.FindObjectOfType<SoundManager>() == null)
            return;

        SoundManager soundManager = GameObject.FindObjectOfType<SoundManager>();
        soundManager.CollectPlay();
    }
}
