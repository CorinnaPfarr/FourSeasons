using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Eatable")]
public class Eatable : Item
{
    public EquipmentSlot equipmentSlot;
    

    public override void Use()
    {
        base.Use();
        Debug.Log("will eat");
        EquipmentManager.instance.Eat();
        Debug.Log("has eaten");
        RemoveFromInventory();

    }

}

