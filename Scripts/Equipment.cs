using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Throwthings")]
public class Equipment : Item
{
    public EquipmentSlot equipmentSlot;


    public override void Use()
    {
        base.Use();
        Debug.Log("will throw");
        EquipmentManager.instance.Throw(this);
        Debug.Log("has thrown");
        RemoveFromInventory();
                 
    }

    }


public enum EquipmentSlot { Snowman, snowballs, Eatables }
