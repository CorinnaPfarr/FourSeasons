using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Flower items : creating bouguet */
/* Code: Corinna Pfarr             */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Flower")]
public class FlowerItems : Item
{
    public EquipmentSlot equipmentSlot;

    // overrides Use method for flower items
    public override void Use()
    {
        base.Use();
        Debug.Log("will build flower bouquet");
        EquipmentManager.instance.FlowerBouquet(this);  // on click of item in inventory 
        Debug.Log("has built flower bouquet");
        RemoveFromInventory();

    }

}