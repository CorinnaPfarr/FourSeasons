using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachTrigger : MonoBehaviour
{
    public GameObject umbrella;
    public Vector3 umbrellaPosition;
    bool isVisable = false;

    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        umbrellaPosition = other.transform.position;


        if (isVisable == false)
        {
            Debug.Log("Press U to place Umbrella");
            GameObject umbrealla = Resources.Load("Umbrella") as GameObject;
            GameObject beachItem = Instantiate(umbrealla) as GameObject;
            beachItem.transform.position = umbrellaPosition;
            isVisable = true;

            Interactions.instance.interactionCountSummer += 1;

        }
        else
        {
            Debug.Log("do Nothing");
        }


    }
}
