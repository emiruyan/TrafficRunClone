using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform carTransform;
    [SerializeField] private float lerpTime;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - carTransform.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, carTransform.position + offset, lerpTime * Time.deltaTime);
        transform.position = newPos;
    }
}
