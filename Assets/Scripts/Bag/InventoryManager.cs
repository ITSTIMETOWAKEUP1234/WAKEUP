using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager Instance;
    public Inventory myBag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public TMP_Text itemInformation;
    public void Awake()
    {
        if (Instance!= null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void OnEnable()
    {
        //RefreshItem();
        //Instance.itemInformation.text = "";
    }
    public static void UpdateItemInfo(string itemDescription)
    {
        Instance.itemInformation.text = itemDescription;
    }
    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(Instance.slotPrefab, Instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(Instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
    }
    //public static void RefreshItem()
    //{
    //  for(int i = 0;i<Instance.slotGrid.transform.childCount;i++)
     //   {
     //       if(Instance.slotGrid.transform.childCount==0)
     //       {
     //           break;
      //      }
      //      Destroy(Instance.slotGrid.transform.GetChild(i).gameObject);
     //   }
     //   for(int i = 0;i< Instance.myBag.itemList.Count;i++)
     //   {
     //       CreateNewItem(Instance.myBag.itemList[i]);
      //  }
    //}
}
