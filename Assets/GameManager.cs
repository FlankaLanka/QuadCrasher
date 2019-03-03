using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("GG");
        SceneManager.LoadScene("ScoringModeEndScreen");
    }
}
