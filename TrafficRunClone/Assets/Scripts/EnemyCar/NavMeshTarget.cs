using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTarget : MonoBehaviour
{
    private NavMeshAgent navMesh;
    public Transform target;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
       
    }

    private void Update()
    {
        navMesh.SetDestination(target.position);
    }
}
