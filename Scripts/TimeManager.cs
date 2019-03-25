using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public string levelToLoad;
    public float startTime;
    private Text theText;
    

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
            //TODO: überlegen was passiert wenn Timer runtergelaufen ist.
            theText.text = "time is over!";
            SceneManager.LoadScene(levelToLoad);
        }

        //displays rounded time 
        theText.text = "" + Mathf.Round (startTime);
    }
}
