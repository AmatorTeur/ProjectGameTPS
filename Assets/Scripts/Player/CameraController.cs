﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform CameraAxisTransform;
    public float minAngle = 1;
    public float maxAngle = 10;
    public float _rotationSpeed = 1;

    void Update()
    {
        var newAngleY = transform.localEulerAngles.y + Time.deltaTime * _rotationSpeed * Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, newAngleY, 0);
        var newAngleX = CameraAxisTransform.localEulerAngles.x + Time.deltaTime * _rotationSpeed * -Input.GetAxis("Mouse Y");
        if (newAngleX > 180) newAngleX -= 360;
        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);
        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
