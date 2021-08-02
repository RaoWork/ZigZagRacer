using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZCarController : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private bool movingLeft = true;
    [SerializeField] private bool firstInput = true;

    void Start()
    {
    }

    void Update()
    {
        if (ZZGameManager.Instance.gameStarted)
        {
            Move();
            CheckInput();
        }

        if(transform.position.y <= -2)
        {
            ZZGameManager.Instance.GameOver();
        }
    }

    void CheckInput()
    {
        if(firstInput)
        {
            firstInput = false;
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }
    }

    void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    void ChangeDirection()
    {
        if (movingLeft)
        {
            movingLeft = false;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else
        {
            movingLeft = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
