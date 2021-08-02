using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZPlatformerSpawner : MonoBehaviour
{

    [SerializeField] private GameObject platform;
    [SerializeField] private Transform lastPlatform;
    Vector3 lastPostion;
    Vector3 newPosition;

    [SerializeField] private bool stop;
    [SerializeField] private float spwanTime = 0.1f;


    void Start()
    {

        lastPostion = lastPlatform.position;
        StartCoroutine(SpawnPlatform());
    }

    void Update()
    {
    }


    IEnumerator SpawnPlatform()
    {
        while (!stop)
        {
            GeneratePostion();
            Instantiate(platform, newPosition, Quaternion.identity);
            lastPostion = newPosition;

            yield return new WaitForSeconds(spwanTime);
        }
    }

    void GeneratePostion()
    {
        newPosition = lastPostion;

        int rand = Random.Range(0, 2);
        if (rand > 0)
        {
            newPosition.x += 2f;
        }
        else
        {
            newPosition.z += 2f;
        }
    }
}
