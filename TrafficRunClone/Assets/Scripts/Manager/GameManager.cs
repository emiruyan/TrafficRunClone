using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.CompareTag("EnemyCar"))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
   }

}




