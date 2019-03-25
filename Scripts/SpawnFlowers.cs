using UnityEngine;

/* Code: Corinna Pfarr        */
/* Spawns flowers in spring   */
/* BUG: Respawns with two ItemPickup Components & Interactable?! */

public class RandomSpawnFlowers : MonoBehaviour
{
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


        //set random x and z axis in set range
        void randomice()
        {
            PlaceX = Random.Range(20, 80);
            PlaceZ = Random.Range(20, 80);

        }

        //Adds Interactable & ItemPickup Scripts to flower objects
        /* not needed anymore
        void addComponents(GameObject obj)
        {
            obj.AddComponent<ItemPickup>();
        }
        */

        // creates flower objects
        void instanciateFlowers()
        {
            // for loop instanciates 15 flowers in set range
            for (int i = 0; i < 15; i++)
            {
                //Instanciates flowers and transform to random position
                // tulip
                GameObject tulip = Instantiate(flower1) as GameObject;
                tulip.transform.position = new Vector3(PlaceX, 10, PlaceZ);
               // addComponents(tulip);

                randomice();

                // dandelion
                GameObject dandelion = Instantiate(flower2) as GameObject;
                dandelion.transform.position = new Vector3(PlaceX, 10, PlaceZ);
                //addComponents(dandelion);

                randomice();

                //daisy
                GameObject daisy = Instantiate(flower3) as GameObject;
                daisy.transform.position = new Vector3(PlaceX, 10, PlaceZ);
               // addComponents(daisy);

                randomice();

                // violet
                GameObject violet = Instantiate(flower4) as GameObject;
                violet.transform.position = new Vector3(PlaceX, 10, PlaceZ);
               // addComponents(violet);
            }

        }
    }
}





