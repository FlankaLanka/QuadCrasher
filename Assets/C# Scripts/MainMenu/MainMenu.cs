using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayHighScoreGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void PlayLevels()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
