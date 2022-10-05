using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed;
    private Vector3 _moveVec;

    private void Update()
    {
        CarInputandMovement();
    }

    private void CarInputandMovement()
    {
        if (Input.GetMouseButton(0))
        {
            _moveVec += transform.forward * carSpeed * Time.deltaTime;
            transform.position += _moveVec * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("EnemyCar"))
        {
           GameManager.Instance.PlayAgain();
        }
    }
}

