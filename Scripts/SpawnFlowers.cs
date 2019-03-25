using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawnFlowers : MonoBehaviour
{
    public GameObject Flowers;      // GameObject
    public float PlaceX;            // X-position
    public float PlaceZ;            // Z-position

    void Start()
    {
        //Load Gameobject Prefabs
        GameObject flower1 = Resources.Load("Tulip") as GameObject;
        GameObject flower2 = Resources.Load("Dandelion") as GameObject;
        GameObject flower3 = Resources.Load("Daisy") as GameObject;
        GameObject flower4 = Resources.Load("Violet") as GameObject;

        // Instanciates flowers
        instanciateFlowers();


        void randomice()
        {
            //set range on x and z axes
            PlaceX = Random.Range(20, 80);
            PlaceZ = Random.Range(20, 80);

        }

        void addComponents(GameObject obj)
        {
            //Adds Interactable & ItemPickup Scripts to flower objects
            obj.AddComponent<ItemPickup>();
        }


        void instanciateFlowers()
        {
            // for loop instanciates 15 flowrs in set range
            for (int i = 0; i < 15; i++)
            {
                //Instanciates flowers and transform to random position
                GameObject tulip = Instantiate(flower1) as GameObject;
                tulip.transform.position = new Vector3(PlaceX, 10, PlaceZ);
                addComponents(tulip);

                randomice();

                GameObject dandelion = Instantiate(flower2) as GameObject;
                dandelion.transform.position = new Vector3(PlaceX, 10, PlaceZ);
                addComponents(dandelion);

                randomice();

                GameObject daisy = Instantiate(flower3) as GameObject;
                daisy.transform.position = new Vector3(PlaceX, 10, PlaceZ);
                addComponents(daisy);

                randomice();

                GameObject violet = Instantiate(flower4) as GameObject;
                violet.transform.position = new Vector3(PlaceX, 10, PlaceZ);
                addComponents(violet);
            }

        }
    }
}





