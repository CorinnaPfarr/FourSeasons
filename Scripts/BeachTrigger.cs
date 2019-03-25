using UnityEngine;

/* Code: Corinna Pfarr               */
/* Spawns umbrella if trigger is hit */

public class BeachTrigger : MonoBehaviour
{
    public GameObject umbrella;         // umbrealla prefab
    public Vector3 umbrellaPosition;    // where umbrealla should move
    bool isVisable = false;             // bool if umbrella already shown


    // when umbrella collider is hit
    private void OnTriggerEnter(Collider other)
    {
        // set position of umbrealla to collider position
        umbrellaPosition = other.transform.position;

        // if not already interacted
        if (isVisable == false)
        {
            Debug.Log("Press U to place Umbrella");  //TODO: Press U to start 

            // loads umbrella and move it to its position
            GameObject umbrealla = Resources.Load("Umbrella") as GameObject;
            GameObject beachItem = Instantiate(umbrealla) as GameObject;
            beachItem.transform.position = umbrellaPosition;
            isVisable = true;

            // increases global interaction count by 1
            Interactions.instance.interactionCountSummer += 1;

        }
        else
        {
            Debug.Log("do Nothing");
        }


    }
}
