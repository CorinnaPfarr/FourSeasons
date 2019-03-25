using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singleton

    public static Inventory instance;

    // check if already an instance & set it to this
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogWarning("more than one instance of inventory found");
            return;
        }

        instance = this;
    }

    #endregion


    //Callback when item gets added/removed
    public delegate void OnItemChanged();   
    public OnItemChanged onItemChangedCallback;

    public int space = 16;   // amount of inventory space

    public List<Item> items = new List<Item>();


    //Add new item to inventory if enough space
    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("not enough space");
            return false;
        }

        items.Add(item);   //Add item

        //trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    
            return true;
    }
            
    public void Remove (Item item)
    {
        items.Remove(item);     //Removes item

        //trigger callback
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
}
