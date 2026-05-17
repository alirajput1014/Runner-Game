using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover_screen : MonoBehaviour
{
    public GameObject gameOverUI;   
    public void ShowGameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;       
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
