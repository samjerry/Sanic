using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float rotationSpeed = 100.0F;
    public float speed;
    private float maxSpeed = 30;
    private float Speedup = 0;
    private Rigidbody rb;
    private Vector3 moveDir;
    private GroundChecker groundCheck;
    public bool freezeRotation;
    int layerMask = 1 << 8;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponentInChildren<GroundChecker>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= (speed + Speedup)* Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (moveDir.sqrMagnitude > 0.5f){
            Speedup += 1;
        }else{
            Speedup = 0;
        }
        if (speed + Speedup > maxSpeed){
            Speedup -= 1;
        }
        RaycastHit hit;
        if (!groundCheck.isGrounded)
        {
            
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

            if (Physics.Raycast(new Ray(this.transform.position, -transform.up), out hit, 3,layerMask))
            {
                print(hit.transform.name);
                print(hit.point.y);
                transform.position = hit.point;
                //transform.position = new Vector3(transform.position.x, (hit.point.y) + transform.position.y/2f, transform.position.z);
                print("raycast is Active");
            } 
        }
    }
}
