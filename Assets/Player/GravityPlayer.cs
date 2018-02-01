using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GravityPlayer : MonoBehaviour{
    public bool gravity = false;
    private void OnTriggerEnter(Collider collision){
        
        if(collision.tag == "Ground"){
            gravity = false;
        }
    }
    private void OnTriggerExit(Collider collision){
        if(collision.tag == "Ground"){
            gravity = true;
        }
    }
}