using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is closed.");
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
