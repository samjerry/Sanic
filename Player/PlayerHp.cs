using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trap")
        {
            Destroy(this.gameObject);
        }
        if (other.tag == "KillGround")
        {
            Destroy(this.gameObject);
        }
    }
}
