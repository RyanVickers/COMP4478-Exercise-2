using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

      public void OnResetButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
    }
}