using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZFollowCamera : MonoBehaviour
{

    [SerializeField] private Transform target;
    Vector3 distance;
    [SerializeField] private float smoothValue;


    void Start()
    {
        if (distance != null)
            distance = target.position - transform.position;
    }

    void Update()
    {
        if (target == null)
            return;

        if (target.position.y >= 0)
            Follow();
    }

    void Follow()
    {
        Vector3 currentPos = transform.position;
        Vector3 targetPos = target.position - distance;

        transform.position = Vector3.Lerp(currentPos, targetPos, smoothValue * Time.deltaTime);
    }
}
