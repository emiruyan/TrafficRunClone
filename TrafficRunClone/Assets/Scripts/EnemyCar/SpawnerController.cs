using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerController : MonoBehaviour
{
  [SerializeField] private float minZ;
  [SerializeField] private float maxZ;
  [SerializeField] private float x;
  [SerializeField] private float spawnInterval;//Objeleri ne sıklıkla spawnlayacağımız
  [SerializeField] private ObjectPoolPattern objectPoolPattern = null;//SpawnController classımızı çağırıyoruz
  private int counter = 0;

  private void Start()
  {
    StartCoroutine(nameof(SpawnRoutine));
  }
  
  private IEnumerator SpawnRoutine()//Sürekli bir döngü halinde Spawn yapacağımız fonksiyon 
  {
   
    while (true)//Sonsuz bir döngü oluşturduk
    {

      GameObject enemyCarPrefab = objectPoolPattern.GetPoolObject(counter++ % 5);//Pooldan bir obje çağırıyoruz
      
      enemyCarPrefab.transform.position = new Vector3(x,0, Random.Range(minZ, maxZ));//Ve bu transform değerlerinde oluşturuyoruz
      
      yield return new WaitForSeconds(spawnInterval);
    }
    
  }
  
}
