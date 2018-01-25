using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapUpDown : MonoBehaviour
{
    private float height = 2f;
    private float _maxSpeed = 2;

    void Start()
    {
        //StartCoroutine()
    }

    void moveVertical()
    {
        float newY = Mathf.Sin(Time.time * _maxSpeed);
        transform.position = new Vector3(transform.position.x, newY * height, transform.position.z);
    }
}
    