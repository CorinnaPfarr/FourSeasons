using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Code: Corinna Pfarr            */
/* Uses eatable item in inventory */

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Eatable")]
public class Eatable : Item
{
    public EquipmentSlot equipmentSlot;

    // overrides Use method for eatable items
    public override void Use()
    {
        base.Use();
        Debug.Log("will eat");
        EquipmentManager.instance.Eat(this); // on click of item in inventory 
        Debug.Log("has eaten");
        RemoveFromInventory();

    }

}

