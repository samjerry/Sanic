using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private float movementSpeed = 10;
    private float Speedup = 0;
    public float _maxSpeed = 30;

    public bool boostTouch;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();

        if (Input.GetKey(KeyCode.W))
        {
            movement += this.transform.forward;
            if (Speedup < _maxSpeed)
            {
                Speedup += 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= this.transform.forward;
            if (Speedup < _maxSpeed)
            {
                Speedup += 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += this.transform.right;
            if (Speedup < _maxSpeed)
            {
                Speedup += 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement -= this.transform.right;
            if (Speedup < _maxSpeed)
            {
                Speedup += 0.1f;
            }
        }

        if (Speedup > _maxSpeed)
        {
            Speedup = _maxSpeed;
        }
        if (Speedup < 0)
        {
            Speedup = 0;
        }
        if (!Input.anyKey)
        {
            Speedup = 0;
        }
        movement.Normalize();
        this.transform.position += (movement * Time.deltaTime * (movementSpeed + Speedup));
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Boost")
        {
            print("touchTrue");
            boostTouch = true;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Boost")
        {
            boostTouch = false;
        }
    }

}
