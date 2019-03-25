using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/SnowmanItems")]
public class SnowmanItems : Item
{
    public EquipmentSlot equipmentSlot;


    public override void Use()
    {
        base.Use();
        Debug.Log("will build");
        EquipmentManager.instance.BuildSnowMan(this);
        Debug.Log("has built");
        RemoveFromInventory();

    }

}