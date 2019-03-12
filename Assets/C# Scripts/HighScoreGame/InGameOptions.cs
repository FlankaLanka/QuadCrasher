using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameOptions : MonoBehaviour
{

    public void ReturntoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PauseGame()
    {
        if (Time.timeScale != 0f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
