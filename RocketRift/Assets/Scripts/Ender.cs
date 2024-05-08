using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOrQuit : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(1); // Load the first scene
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the application
    }
}
