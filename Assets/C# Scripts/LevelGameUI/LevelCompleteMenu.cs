using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelCompleteMenu : MonoBehaviour
{
    public GameObject LevelCompleteUI;
    // Start is called before the first frame update
    void Start()
    {
        LevelCompleteUI.SetActive(false);
    }


    public void ReturntoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SelectLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Select");
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
