using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject completeLevelUI;
    
    public void FinishedLevel()
    {
        if (!isGameOver)
        {
            completeLevelUI.SetActive(true);
            isGameOver = true;
            Invoke(nameof(NestLevel), 2);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void EndGame()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Invoke(nameof(ReloadLevel), 1.0f);
        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    private void NestLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
