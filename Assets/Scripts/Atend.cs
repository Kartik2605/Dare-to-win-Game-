using UnityEngine;

public class Atend : MonoBehaviour
{
    public gamemanager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
