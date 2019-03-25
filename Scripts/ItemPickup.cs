using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    

    public override void Interact()
    {
        //executes code of base Interact() method
        base.Interact();

        PickUp();
        
    }

    //picks up Item
    void PickUp()
    {
        Debug.Log("Picking up" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        //if succesfully picked up
        if (wasPickedUp)
             Destroy(gameObject);     //Remove item from scene
    }
}
