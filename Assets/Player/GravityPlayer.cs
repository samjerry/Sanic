using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPlayer : MonoBehaviour
{

    public bool isGrounded;
    private void Update()
    {
        RaycastHit hit;
        //checks if the player is on the floor or in the air with an raycast
        if (Physics.Raycast(this.transform.position, -transform.up, out hit))
        {
            
        }
    }
}