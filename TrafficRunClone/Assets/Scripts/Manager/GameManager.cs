using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
public Button tryAgainButton;
    
    public void NextLevel()
  {
    SceneManager.LoadScene(1);
  }
  
  public void PlayAgain()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}




