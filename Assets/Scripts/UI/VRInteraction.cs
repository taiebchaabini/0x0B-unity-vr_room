using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VRInteraction : MonoBehaviour
{
    // Script 
    public void Interact()
    {
        if (gameObject.name == "glass_panel_1_door")
        {
            transform.parent.GetComponent<Animator>().SetBool("character_nearby", true);
            transform.parent.GetComponent<NavMeshObstacle>().enabled = false;
        }
        Debug.Log(gameObject.name);
    }
}
