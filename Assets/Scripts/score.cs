using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text Scoretext;
   
    void Update()
    {
        Scoretext.text = player.position.z.ToString("0");
    }
}
