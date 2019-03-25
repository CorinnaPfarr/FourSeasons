using UnityEngine;
using UnityEngine.SceneManagement;

/* Code: Corinna Pfarr                            */
/* Manages time and change level if time runs out */

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        // loads next scene by clicking PlayButton
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        // Quits the Game by clicking QuitButton
        Application.Quit();
    }


}
