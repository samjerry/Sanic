using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Camera camerMain;
    public Camera camerSide;
    public float overFinish = 2;

    void Start()
    {
        camerMain.enabled = true;
        camerSide.enabled = false;
    }

    IEnumerator ColFinish()
    {
        while (true)
        {
           
            camerMain.enabled = false;
            camerSide.enabled = true;

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
}


