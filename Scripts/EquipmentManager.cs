using UnityEngine;
using UnityEngine.UI;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=d9oLS5hy0zU
 * Corinna Pfarr added own methods: Throw / Eat / BuildSnowMan / FlowerBouquet
 */

public class EquipmentManager : MonoBehaviour
{
    #region Singleton

    public static EquipmentManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public Transform target;
    public Interactions interactionCountWinter;
    public Rigidbody rb;

    public Vector3 playerposition;
    public Vector3 snowBase;
    public Vector3 NewSnowBase;
    public Vector3 rotation;
    public Vector3 endPosition;

    Equipment[] currentEquipment;

    void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlots];
    }

    // equips item
    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.equipmentSlot;
        currentEquipment[slotIndex] = newItem;
    }

    // throws item away from player
    public void Throw(Equipment newItem)
    {
        //get current position of player
        playerposition = GameObject.Find("Player").transform.position;

        int throwCount = 0;

        GameObject snowTop = Resources.Load("Snowball") as GameObject;    // find prefab in resources
        GameObject top = Instantiate(snowTop) as GameObject;                 // instanciate prefab
        top.AddComponent<Rigidbody>();
        top.transform.position = playerposition;

        // get Rigidbody of snowball and add Force to it
        rb = top.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 20f, ForceMode.Impulse);

        throwCount = +1;

        if (throwCount == 1)
        {
            // increases interactionCount for Level winter by 1
            Interactions.instance.interactionCountWinter += 1;

        }
    }

    // eats item, and shows text (COULDDOLATER: increasing healthbar)
    public void Eat(Eatable newItem)
    {
        Debug.Log(" Eat Item  ");

    }

    // building a snowman 
    public void BuildSnowMan(SnowmanItems newItem)
    {
        int snowManCount = 0;
        //get current position of snowManBase
        snowBase = GameObject.Find("SnowmanBase").transform.position;
        Debug.Log(snowBase); //BUG: Logs wrong position?

        if (newItem.name == "SnowManMiddle")
        {
            NewSnowBase.x = snowBase.x;
            NewSnowBase.y = snowBase.y + 2f;             // sets Snowball on top of SnowBase
            NewSnowBase.z = snowBase.z;

            GameObject snowItem = Resources.Load(newItem.name) as GameObject;     // find prefab in resources with same item name
            GameObject top = Instantiate(snowItem) as GameObject;                 // instanciate prefab
            top.AddComponent<Rigidbody>();
            top.transform.position = NewSnowBase;
            snowManCount++;
            Debug.Log(snowManCount);
        }
        else if (newItem.name == "SnowManTop")
        {
            NewSnowBase.x = snowBase.x;
            NewSnowBase.y = snowBase.y + 8f;        // sets Snowball on top of SnowBase
            NewSnowBase.z = snowBase.z;

            GameObject snowItem = Resources.Load(newItem.name) as GameObject;     // find prefab in resources with same item name
            GameObject top = Instantiate(snowItem) as GameObject;                 // instanciate prefab
            top.AddComponent<Rigidbody>();
            top.transform.position = NewSnowBase;
            snowManCount++;
            Debug.Log(snowManCount);
        }
        else if (newItem.name == "Twig")
        {
            //TODO: not hard code the position
            NewSnowBase.x = snowBase.x + 2f;
            NewSnowBase.y = snowBase.y + 2f;        // sets Snowball on top of SnowBase
            NewSnowBase.z = snowBase.z;

            endPosition = NewSnowBase;

            GameObject snowItem = Resources.Load(newItem.name) as GameObject;     // find prefab in resources with same item name
            GameObject top = Instantiate(snowItem) as GameObject;                 // instanciate prefab
            top.AddComponent<Rigidbody>();
            rb = top.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = false;

            if (transform.position != endPosition)
            {
                top.transform.rotation = Quaternion.Euler(45f, 0, 0);                 // rotate by 45 degree
                top.transform.position = Vector3.MoveTowards(transform.position, endPosition, 10f * Time.deltaTime);
                Debug.Log(top.transform.position);
                snowManCount++;
                Debug.Log(snowManCount);
            }
        }

        else if (newItem.name == "Twig2")
        {
            //TODO: not hard code the position && set to right angle
            NewSnowBase.x = snowBase.x + 2f;
            NewSnowBase.y = snowBase.y - 2f; ;        // sets Snowball on top of SnowBase
            NewSnowBase.z = snowBase.z;

            endPosition = NewSnowBase;


            GameObject snowItem = Resources.Load(newItem.name) as GameObject;     // find prefab in resources with same item name
            GameObject top = Instantiate(snowItem) as GameObject;                 // instanciate prefab
            top.AddComponent<Rigidbody>();
            rb = top.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = false;

            if (transform.position != endPosition)
            {
                top.transform.rotation = Quaternion.Euler(45f, 180, 0);                 // rotate by 45 degree
                top.transform.position = Vector3.MoveTowards(transform.position, endPosition, 10f * Time.deltaTime);
                Debug.Log(top.transform.position);
                snowManCount++;
                Debug.Log(snowManCount);
            }


        }
        else
        {
            Debug.Log("didn't work");
        }

        if (snowManCount == 4)
        {
            Debug.Log(snowManCount);
            Interactions.instance.interactionCountWinter += 1;

        }

    }

    // creating a flower bouquet
    public void FlowerBouquet(FlowerItems newItem)
    {
        Debug.Log("do something with flowers");
        Interactions.instance.interactionCountSpring += 1;
    }
}


