using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToClick : MonoBehaviour
{
    public Item item;
    public Inventory playerInventory;
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 1000);
            if (hit.collider != null && hit.collider.tag == "item")
            {
                AddNewItem();
                Destroy(gameObject); 
            }
        }       
    }
    public void AddNewItem()
    {
        if(!playerInventory.itemList.Contains(item))
        {
            playerInventory.itemList.Add(item);
        }
        //InventoryManager.RefreshItem();
    }
}