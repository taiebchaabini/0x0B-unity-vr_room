using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using OculusSampleFramework;

public class VRInteraction : MonoBehaviour
{
    private bool doorAccess;
    private GameObject DistanceGrabHandRight;
    private GameObject item;
    private int interactions;

    public void Start()
    {
        doorAccess = false;
        DistanceGrabHandRight = GameObject.Find("DistanceGrabHandRight");
        interactions = 0;
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
        else if (gameObject.name == "Projector")
        {
            if (interactions >= 4)
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (doorAccess && transform.parent.parent.parent.name == "ChessBoard")
        {
            item = GameObject.Find(gameObject.name + "Key");
            if (item != null && item.GetComponent<DistanceGrabbable>().isGrabbed)
            {
                GameObject.Find("Projector").GetComponent<VRInteraction>().interactions += 1;
                gameObject.GetComponent<Renderer>().material = item.GetComponent<Renderer>().material;
                Destroy(item);
                item = null;
                // Must add a playsound
            } else{
                Debug.Log("Error sound");
            }
        }
    
        Debug.Log(gameObject.name);
    }
}
