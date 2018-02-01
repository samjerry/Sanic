using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{
    public float rotationSpeed = 100.0F;
    public float speed;
    private float maxSpeed = 50;
    private float Speedup = 0;
    private float timer = 0;
    public float angle;
    private Rigidbody rb;
    private Vector3 moveDir;
    private GravityPlayer gravityPlayer;
    public bool freezeRotation;
    public bool isGrounded;
    public GameObject player;
    bool timeTrue;
    int layerMask = 1 << 8;
    private Vector3 upright;
    private float slopeAngle;

    private void Start(){
        rb = GetComponent<Rigidbody>();
        gravityPlayer = GetComponentInChildren<GravityPlayer>();
        slopeAngle = Vector3.SignedAngle(moveDir, transform.forward, Vector3.down);
    }

    void Update(){
        CheckGrounded();
        PlayerMovement();
        if (moveDir.sqrMagnitude > 0.5f){
            Speedup += 0.5f;
        }
        else{
            Speedup = 0;
        }
        if (speed + Speedup > maxSpeed){
            Speedup -= 1;
        }

        RaycastHit hit;
        //players sticks to the ground
            if (Physics.Raycast(new Ray(this.transform.position, -transform.up), out hit, 5, layerMask)){
            transform.position = hit.point;
            }
        Debug.DrawRay(transform.position, transform.TransformDirection(-Vector3.up)*5, Color.white);

    }
    private void PlayerMovement(){
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= (speed + Speedup) * Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
    private void CheckGrounded(){
        if (gravityPlayer.gravity){
            rb.useGravity = true;
        }
        else{
            rb.useGravity = false;
        }
    }
}