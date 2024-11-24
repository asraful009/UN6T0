using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    
    public void GoToLevel()
    {
        SceneManager.LoadScene(0);
    }
    
    public void GoToLevelPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
