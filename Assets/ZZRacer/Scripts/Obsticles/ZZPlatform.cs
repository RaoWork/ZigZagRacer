using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZPlatform : MonoBehaviour
{


    [SerializeField] string playerTagName = "Car_Model";
    [SerializeField] GameObject diamondCollect;
    [SerializeField] float fallTime = 0.3f;
   

    void Start()
    {
        GenerateDiamond();
    }

    void Update()
    {
    }

    void GenerateDiamond()
    {
        if (diamondCollect == null)
            return;

        int rand = Random.Range(0, 5);
        Vector3 diamondPos = transform.position;
        diamondPos.y += 1f;

        if(rand < 1)
        {
            Instantiate(diamondCollect, diamondPos, diamondCollect.transform.rotation);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == playerTagName)
        {
            Invoke("Fall", fallTime);
        }
    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        Destroy(gameObject, 0.5f);
    }
}
