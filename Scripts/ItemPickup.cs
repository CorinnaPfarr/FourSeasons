using UnityEngine;

/* Lets player pick up items       */
/* Code: Corinna Pfarr             */

public class ItemPickup : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();

    }

    //Picks up an item and removes it from scene
    void PickUp()
    {
        Debug.Log("Picking up" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        //if succesfully picked up
        if (wasPickedUp)
            Destroy(gameObject);
    }
}
