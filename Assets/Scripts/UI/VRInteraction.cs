using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VRInteraction : MonoBehaviour
{
    private bool doorAccess;

    public void Start()
    {
        doorAccess = false;
    }
    // Script 
    public void Interact()
    {
        doorAccess = GameObject.Find("Goals").transform.Find("StorageRoom").transform.Find("Console").gameObject.GetComponent<Console>().accessGranted;
        if (doorAccess && gameObject.name == "glass_panel_1_door")
        {
            transform.parent.GetComponent<Animator>().SetBool("character_nearby", true);
            transform.parent.GetComponent<NavMeshObstacle>().enabled = false;
        }
        Debug.Log(gameObject.name);
    }
}
