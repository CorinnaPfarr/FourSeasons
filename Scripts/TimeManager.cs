using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* Code: Corinna Pfarr                            */
/* Manages time and change level if time runs out */

public class TimeManager : MonoBehaviour
{
    public string levelToLoad;      // which level next
    public float startTime;         // initial time
    private Text theText;           // where it's displayed
    

    // Start is called before the first frame update
    void Start()
    {
        //sets text component
        theText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // decreases time
        startTime -= Time.deltaTime;

        if (startTime <= 0 )
        {
            // change to next Level if time is over
            theText.text = "time is over!";
            SceneManager.LoadScene(levelToLoad);
        }

        //displays rounded time 
        theText.text = "" + Mathf.Round (startTime);
    }
}
