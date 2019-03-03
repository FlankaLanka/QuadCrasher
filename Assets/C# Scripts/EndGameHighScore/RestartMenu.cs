using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ReturntoStart()
    {
        SceneManager.LoadScene("Menu");
    }

}