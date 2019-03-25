using UnityEngine;

/* Code: Corinna Pfarr                            */
/* Spawns pickable snowballs in winter */

public class SpawnSnowballs : MonoBehaviour
{
    public float PlaceX;            // X-position
    public float PlaceZ;            // Z-position

    // Start is called before the first frame update
    void Start()
    {
        GameObject snowball = Resources.Load("Snowball") as GameObject;

        //instanciate snowballs for snowman
        instanciateSnowballs();

        void addComponents(GameObject obj)
        {
            obj.AddComponent<ItemPickup>();
        }

        void randomice()
        {
            //set range on x and z axes
            PlaceX = Random.Range(20, 180);
            PlaceZ = Random.Range(20, 180);
        }

        // instanciate snowball prefabs
        void instanciateSnowballs()
        {
            for (int i = 0; i < 15; i++)
            {
                randomice();
                GameObject top = Instantiate(snowball) as GameObject;
                top.transform.position = new Vector3(PlaceX, 10f, PlaceZ);
                addComponents(top);
            }

        }

    }
}
