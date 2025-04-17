using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverUI;
    public TextMeshProUGUI finalScoreText;


    void Awake()
    {
        instance = this;
        Time.timeScale = 1;
        gameOverUI.SetActive(false);
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0;

        if (gameOverUI != null)
            gameOverUI.SetActive(true);

        if (finalScoreText != null)
            finalScoreText.text = "Score final : " + score;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
