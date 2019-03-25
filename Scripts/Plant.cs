using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public GameObject plant;
    public GameObject pot;
    public Vector3 potPosition;
    public Vector3 plantPosition;
    bool isPlanted = false;

    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        potPosition = GameObject.Find("Pot1").transform.position;
        plantPosition.x = potPosition.x;
        plantPosition.y = potPosition.y + 2.8f ;
        plantPosition.z = potPosition.z;
        

        if (isPlanted == false)
        { 

        Debug.Log("Press P to plant a new plant");
        GameObject oleander = Resources.Load("Oleander") as GameObject;
        GameObject plant = Instantiate(oleander) as GameObject;
        plant.transform.position = plantPosition;
        isPlanted = true;

        Interactions.instance.interactionCountSpring += 1;

        }
        else
        {
            Debug.Log("do Nothing");
        }


    }

}
