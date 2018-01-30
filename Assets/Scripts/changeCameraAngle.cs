using UnityEngine;
using System.Collections;

public class changeCameraAngle : MonoBehaviour
{
    public Transform view;
    public float transitionSpeed;
    Transform currentView;

    private bool _isFinished;

    void LateUpdate()
    {
        _isFinished = GameObject.Find("Finish").GetComponent<Finish>().isFinished;

        if (_isFinished == true)
        {
            currentView = view;
            CameraUpdate();
        }
    }

    public void CameraUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
            
    }

}