using UnityEngine;

/* Code: Corinna Pfarr               */
/* Interacting with Picknick */

public class PicknickTrigger : MonoBehaviour
{
    bool hasInteracted = false;             // bool if umbrella already shown


    // destroy fruits if triggerd
    private void OnTriggerEnter(Collider other)
    {
        if (hasInteracted == false)
        {
            Debug.Log("Press P to interact with picknick");  //TODO: Press P to start 

            GameObject picknick = GameObject.Find("Picknick");

            for (int i = 0; i < picknick.transform.childCount; i++)
            {
                Debug.Log(i);
                GameObject fruits = picknick.transform.GetChild(i).gameObject;
                Debug.Log(fruits.name);
                Destroy(fruits);
                hasInteracted = true;

                // increases global interaction count by 1
                Interactions.instance.interactionCountSummer += 1;
            }

        }
        else
        {
            Debug.Log("do Nothing");
        }
    }
}

