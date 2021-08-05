using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RippleHit : MonoBehaviour
{

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("Its over UI elements");
            return;
        }


        if (Input.GetMouseButtonDown(0))
        {
            animator.transform.position = Input.mousePosition;
            PlayRipple();
        }
    }

    void PlayRipple()
    {
        if (animator == null)
            return;

        animator.Play("RippleHit", -1, 0f);
    }
}
