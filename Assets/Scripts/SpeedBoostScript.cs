using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostScript : MonoBehaviour
{
    public Camera camerMain;
    public Camera camerSide;
    bool boostTouch;

    void Start()
    {

    }

    void Update()
    {
        boostTouch = GameObject.Find("Player").GetComponent<PlayerMovement>().boostTouch;

        if (boostTouch == true)
        {
            camerMain.enabled = false;
            camerSide.enabled = true;
        }
        else
        {
            camerMain.enabled = true;
            camerSide.enabled = false;
        }
    }

}
