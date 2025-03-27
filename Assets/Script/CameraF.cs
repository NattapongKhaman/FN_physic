using System;
using UnityEngine;

public class CameraF : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0,1.5f,-5);

    private void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
