using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool singleton=true;
    public GameObject complitLevelUI;

    public void EndGame()
    {
        if (singleton)
        {
            singleton = false;
            Debug.Log("Game Over");
            Invoke("Restart", 2f);
        }        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompliteLevel()
    {
        complitLevelUI.SetActive(true);
    }
}
