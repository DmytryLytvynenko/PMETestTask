using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRotate : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField] private Transform cameraRoot;
    [SerializeField] private float rotationSensitivity;
    [SerializeField] private float minVerticalAngle;
    [SerializeField] private float maxVerticalAngle;

    public void OnBeginDrag(PointerEventData ped) { }
    public void OnDrag(PointerEventData ped)
    {
        float xRotation = cameraRoot.localEulerAngles.x + ped.delta.y * rotationSensitivity;
        Debug.Log(xRotation);
        xRotation = Mathf.Clamp(xRotation, minVerticalAngle, maxVerticalAngle);
        float yRotation = cameraRoot.localEulerAngles.y + ped.delta.x * rotationSensitivity;

        cameraRoot.localEulerAngles = new Vector3(xRotation, yRotation, 0);
    }
}
