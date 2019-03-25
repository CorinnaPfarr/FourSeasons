using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSeasons : MonoBehaviour
{
    public int index;
    public int interactionCount;
    


    //change season after all interactions found
   // void countInterations ()
   // {
   //     allInteractionsFound();
   // }




    void allInteractionsFound()
    {
        if (interactionCount == 5)
        {
            // Load next level
            SceneManager.LoadScene(index);
          
        }
    }
}
