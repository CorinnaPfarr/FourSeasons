using UnityEngine;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=w6_fetj9PIw&t=2s
 * UI of the Inventory
 */

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;


    void Start()
    {
        // updates UI if something is added or removed
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        inventory = Inventory.instance;
    }

    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }


    void UpdateUI()
    {
        //loop trough slots to find empty slot

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);

            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }






}
