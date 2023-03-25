using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    public float RotateSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up * (RotateSpeed * Time.deltaTime));
    }
}
