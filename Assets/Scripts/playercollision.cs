using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obsticle")
        {
            Debug.Log("We hit something");
            movement.enabled = false;
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
