using UnityEngine;


public class Respawn : MonoBehaviour
{
    
    public GameObject FloatingText;
    public Transform player;
    public Transform respawnPoint;
    

   void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            // simple respawn point
            player.transform.position = respawnPoint.transform.position;
            if (FloatingText != null)
            {
                ShowRespawnText();
            }
        }   
    }

   void ShowRespawnText ()
        {
            Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        }
    


}
