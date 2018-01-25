using UnityEngine;
using System.Collections;

public class NormalCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float smoothspd = 0.5f;  

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 newPos = player.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, newPos, smoothspd);
        transform.position = smoothedPos;

        transform.LookAt(player);
    }
}