using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Flower")]
public class FlowerItems : Item
{
    public EquipmentSlot equipmentSlot;


    public override void Use()
    {
        base.Use();
        Debug.Log("will do something");
        EquipmentManager.instance.FlowerThing(this);
        Debug.Log("has done something");
        RemoveFromInventory();

    }

}
