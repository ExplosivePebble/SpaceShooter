using UnityEngine.SceneManagement;
using UnityEngine;

public class Events3 : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level3");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}