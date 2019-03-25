using UnityEngine;
using UnityEngine.UI;

/* Code: Corinna Pfarr      */
/* Counts interactions of every season and displays it in Outro */

public class Interactions : MonoBehaviour
{
    public static Interactions instance;
    public Text springText;
    public Text summerText;
    public Text autumnText;
    public Text wintertext;
    public Text theText;

    public int interactionCountSpring;
    public int interactionCountSummer;
    public int interactionCountAutumn;
    public int interactionCountWinter;

    // Update is called once per frame
    void Start()
    {
        //instanciates
        instance = this;

        // set start interaction to zero
        interactionCountSpring = 0;
        interactionCountSummer = 0;
        interactionCountAutumn = 0;
        interactionCountWinter = 0;

    }


    void Update()
    {
        string spring = instance.interactionCountSpring.ToString();
        string summer = instance.interactionCountSummer.ToString();
        string autumn = instance.interactionCountAutumn.ToString();
        string winter = instance.interactionCountWinter.ToString();

        springText.text = "" + spring;
        summerText.text = "" + summer;
        autumnText.text = "" + autumn;
        wintertext.text = "" + winter;


    }
}

