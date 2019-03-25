using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=S2mK6KFdv0I
 * corinna Pfarr edited Methos Throw() and Enum Equipmentslot  */

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Throwthings")]
public class Equipment : Item
{
    public EquipmentSlot equipmentSlot;

    // overrides Use method for eatable items
    public override void Use()
    {
        base.Use();
        Debug.Log("will throw");
        EquipmentManager.instance.Throw(this); // on click of item in inventory 
        Debug.Log("has thrown");
        RemoveFromInventory();
    }

}

// Enum of which item types it should be
public enum EquipmentSlot { Snowman, Snowballs, Eatables, Flowers }
