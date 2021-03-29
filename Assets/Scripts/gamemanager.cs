using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;

    public float restartdelay = 4f;

    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }
   
    public void endgame ()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartdelay);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
