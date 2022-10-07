using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed;
    private Vector3 _moveVec;


    private void Start()
    {
        Time.timeScale = 1;
    }

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
            Time.timeScale = 0;
            GameManager.Instance.tryAgainButton.gameObject.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("FinishFloor"))
        {
            GameManager.Instance.NextLevel();
        }
    }
    
}


