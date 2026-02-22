using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    
    void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
