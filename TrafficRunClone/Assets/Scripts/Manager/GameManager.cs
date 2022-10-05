using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
  public void PlayAgain()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}




