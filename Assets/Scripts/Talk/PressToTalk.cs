using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PressToTalk : MonoBehaviour
{
    public int ID;
    public int NextID;
    public bool firsttime=true;
    public GameObject player;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(firsttime) 
            { 
                ID=NextID;
                firsttime=false;
            }
            player.GetComponent<PlayerMovement>().enabled = false;
            DialogeManager.instance.ShowDialogue(ID);
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
