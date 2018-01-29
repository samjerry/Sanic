using UnityEngine;
using System.Collections;

public class NormalCamera : MonoBehaviour
{
    [SerializeField]private Transform target;
    [SerializeField]private Vector3 offsetPosition;
    [SerializeField]private bool lookAt = true;

    private Space offsetPositionSpace = Space.Self;

    private void LateUpdate()
    {
        CameraUpdate();
    }

    public void CameraUpdate()
    {     
        transform.position = target.TransformPoint(offsetPosition);

        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }

}