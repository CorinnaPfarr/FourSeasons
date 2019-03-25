using UnityEngine;

/* Code: Corinna Pfarr        */
/* class to plant a Plantain  */

public class Plant : MonoBehaviour
{
    public Vector3 potPosition;         // position of the flowerpot
    public Vector3 plantPosition;       // position where plant should be planted
    bool isPlanted = false;             // bool to see if already planted

    // if player collides with trigger
    private void OnTriggerEnter(Collider other)
    {
        // find potposition and set new plant position
        potPosition = GameObject.Find("Pot1").transform.position;
        plantPosition.x = potPosition.x;
        plantPosition.y = potPosition.y + 2.6f;
        plantPosition.z = potPosition.z;

        // if not already planted
        if (isPlanted == false)
        {

            Debug.Log("Press P to plant a new plant");      //  TODO: show text to interact

            //instanciate prefab of oleander
            GameObject plantain = Resources.Load("Plantain") as GameObject;
            GameObject plant = Instantiate(plantain) as GameObject;

            // move plant to new position and set isPlanted to true
            plant.transform.position = plantPosition;
            isPlanted = true;

            // increase global Interactioncount for  spring by one
            Interactions.instance.interactionCountSpring += 1;

        }
        else
        {
            // if already planted
            Debug.Log("do Nothing");
        }


    }

}
