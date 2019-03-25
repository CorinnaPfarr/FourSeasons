using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LakeTrigger : MonoBehaviour
{
    public Interactions interactionCountWinter;
    public Text LakeText;
    bool hasinteracted;

    void Start()
    {
        //LakeText = GetComponent<Text>();
        //LakeText.enabled = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (hasinteracted == false)
        {
           // LakeText.text = "You can't swim here.";
           // LakeText.enabled = true;
            Debug.Log("You can't swim here");       // logging because i can't make showing Text work :(
            Interactions.instance.interactionCountWinter += 1;
            hasinteracted = true;

        }
        else
        {
            Debug.Log("do nothing");
        }


    }
}
