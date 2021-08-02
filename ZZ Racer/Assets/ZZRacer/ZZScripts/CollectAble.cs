using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAble : MonoBehaviour
{


    void Start()
    {
    }

    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Car")
        {
            GameObject.FindObjectOfType<ZZScoreManager>().ScoreBonus(10);
            Destroy(gameObject, 0f);
        }
    }
}
