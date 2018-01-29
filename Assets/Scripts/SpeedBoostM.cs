using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostM : MonoBehaviour
{
    public Camera camerMain;
    public Camera camerSide;

    void Start()
    {
        camerMain.enabled = true;
        camerSide.enabled = false;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Boost")
        {
            print("touchTrue");
            camerMain.enabled = false;
            camerSide.enabled = true;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Boost")
        {
            camerMain.enabled = true;
            camerSide.enabled = false;
        }
    }

}
