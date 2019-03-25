using UnityEngine;

/* Code: Corinna Pfarr      */
/* Uses snowman items in inventory */

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/SnowmanItems")]
public class SnowmanItems : Item
{
    public EquipmentSlot equipmentSlot;

    // overrides Use method for snowman items
    public override void Use()
    {
        base.Use();
        Debug.Log("will build");
        EquipmentManager.instance.BuildSnowMan(this); // on click of item in inventory 
        Debug.Log("has built");
        RemoveFromInventory();

    }

}