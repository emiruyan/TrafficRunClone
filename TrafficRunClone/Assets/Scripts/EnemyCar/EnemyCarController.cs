using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyCarController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        Destroy(gameObject, lifeTime);
    }
}
