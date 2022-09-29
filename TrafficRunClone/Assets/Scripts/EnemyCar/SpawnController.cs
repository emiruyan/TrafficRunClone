using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
   [SerializeField] private GameObject enemyCarPrefab;
   [SerializeField] private float minZ;
   [SerializeField] private float maxZ;
   [SerializeField] private float x;
   [SerializeField] private float interval;


   private void Start()
   { 
      InvokeRepeating("CarSpawn", interval, interval);
   }

   private void CarSpawn()
   {
      GameObject instance = Instantiate(enemyCarPrefab);
      instance.transform.position = new Vector3(x, 1, Random.Range(minZ,maxZ));
   }


}
