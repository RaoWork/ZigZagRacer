using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public LevelLoader.SceneName levelName;


    void Start()
    {
    }

    void Update()
    { 
    }

    public void LoadLevel(LevelLoader.SceneName _customLevelName)
    {
        LevelLoader.Load(_customLevelName);
    }

    public void LoadLevel()
    {
        LevelLoader.Load(levelName);
    }
}
