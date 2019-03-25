using UnityEngine;
using UnityEngine.UI;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=d9oLS5hy0zU
 */

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;

    Item item;

    // Add item to inventory, updating UI
    public void AddItem(Item newItem)

    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    // remove icon of inventory
    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    // remove item of inventory if clicking remove button
    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    // calls base Use method
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }

}
