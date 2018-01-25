using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float movementSpeed = 16;
    private float maxSpeed = 50;
    private float Speedup = 0;
    public bool freezeRotation;
    public Rigidbody rigidBody;
    public GroundChecker grounded;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void Update(){
        grounded = transform.GetChild(0).GetComponent<GroundChecker>();
        Vector3 movement = new Vector3();

        //checks if the player is grounded, then slowes him if it is true
        if (!grounded){
            Speedup -= 4f;
        }
        //Forward movement with an speedup if the player is grounded
        if (Input.GetKey(KeyCode.W)){
            movement += this.transform.forward;
            if (Speedup < maxSpeed && grounded.isGrounded){
                Speedup += 4f;
            }
        }
        //backwards movement with an speedup if the player is grounded
        if (Input.GetKey(KeyCode.S)){
            movement -= this.transform.forward;
            if (Speedup < maxSpeed && grounded.isGrounded){
                Speedup += 4f;
            }
        }
        //right movement with an speedup if the player is grounded
        if (Input.GetKey(KeyCode.D)){
            movement += this.transform.right;
            if (Speedup < maxSpeed && grounded.isGrounded){
                Speedup += 4f;
            }
        }
        //left movement with an speedup if the player is grounded
        if (Input.GetKey(KeyCode.A)){
            movement -= this.transform.right;
            if (Speedup < maxSpeed && grounded.isGrounded){
                Speedup += 4f;
            }
        }
        if(grounded.isGrounded == true)
        {
            rigidBody.freezeRotation = false; 
        }
        else
        {
            rigidBody.freezeRotation = true;
        }
        if (Speedup > maxSpeed)
        {
            Speedup = 30;
        }
        if (Speedup < 0){
            Speedup = 0;
        }
        if (!Input.anyKey){
            Speedup = 0;
        }
        movement.Normalize();
        //movement speed manager
        this.transform.position += (movement * Time.deltaTime * (movementSpeed + Speedup));
    }
    
}
