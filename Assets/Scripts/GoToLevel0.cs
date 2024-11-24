using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel0 : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene(0);
    }
}
