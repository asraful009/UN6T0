using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EndGame()
    {
        if (!isGameOver) 
            Invoke(nameof(LevelLoaded), 2);
    }

    private void LevelLoaded()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
