using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelLoader
{
    private class LoadingMonoBehaviour : MonoBehaviour { }; // for Start Coroutiene

    public static void Load(SceneName _Scene)
    {
        GameObject loading = new GameObject("Loading Gameobject");
        loading.AddComponent<LoadingMonoBehaviour>().StartCoroutine(LoadSceneAsync(_Scene));
    }

    private static IEnumerator LoadSceneAsync(SceneName _Scene)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadSceneAsync(_Scene.ToString());
    }

    public static void Unload(SceneName _Scene)
    {
        SceneManager.UnloadSceneAsync(_Scene.ToString());
    }

    public enum SceneName
    {
        ZzSplash,
        ZzGameplay
    }
}
