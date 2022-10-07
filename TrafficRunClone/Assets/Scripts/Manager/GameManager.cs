using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    [HideInInspector] public int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    public Button tryAgainButton;
    
    public void NextLevel()
  {
    SceneManager.LoadScene(1);
  }
  
  public void PlayAgain()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  public void GameScore()
  {
      score++;
      scoreText.text = score.ToString();
      
  }
}




