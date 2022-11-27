using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] float cameraSensitivity;
    [SerializeField] float minY, maxY;
    [SerializeField] float rotationSmoothTime;

    float yaw, pitch;

    Vector3 currentRotation;
    Vector3 rotationSmoothVelocity;
    void Start()
    {
        
    }

private void LateUpdate()
{
    OrbitPlayer();
}
    
    void OrbitPlayer()
    {
        transform.position = player.transform.position;

        yaw += Input.GetAxis("Mouse X") * cameraSensitivity * Time.fixedDeltaTime;
        pitch += Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;

        pitch = Mathf.Clamp(pitch, minY, maxY);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime * Time.deltaTime);

        transform.eulerAngles = currentRotation;
    }
}
