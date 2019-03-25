using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    //blueprint for every item
    new public string name = "New Item";
    public Sprite icon = null;              // icon which shows in inventory 

    public virtual void Use()
    {
        //Use Item
        Debug.Log("using" + name);
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
