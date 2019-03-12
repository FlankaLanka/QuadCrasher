using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;

    public GameObject PauseMenuUI;

    

    void Start()
    {
        PauseMenuUI.SetActive(false);
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            if(Paused == true)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        
    }

    public void ResumeGame()
    {
        Paused = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f; 
    }

    void PauseGame()
    {
        Paused = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        Scene CurrentLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(CurrentLevel.name);
    }

    public void ReturntoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
