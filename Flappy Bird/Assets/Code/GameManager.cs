using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

}
