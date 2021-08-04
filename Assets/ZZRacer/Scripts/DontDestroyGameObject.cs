using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyGameObject : MonoBehaviour
{

   
    void Start()
    {
        int levelsController = FindObjectsOfType<DontDestroyGameObject>().Length;
        if (levelsController != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
