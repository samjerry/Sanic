using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private float overFinish = 2;

    public float speed;
    public bool isFinished = false;

    void Start()
    {
       
    }

    IEnumerator ColFinish()
    {
        while (true)
        {
            changeAngle();
            yield return new WaitForSeconds(5f);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            overFinish -= 1;
            print(overFinish);

            if (overFinish == 0)
            {
                StartCoroutine(ColFinish());
            }
        }
    }

    void changeAngle()
    {
        isFinished = true;
    }
}


