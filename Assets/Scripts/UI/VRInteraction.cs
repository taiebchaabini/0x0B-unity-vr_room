using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInteraction : MonoBehaviour
{
    // Script 
    public void Interact()
    {
        if (gameObject.name == "glass_panel_1_door")
        {
            if (!transform.parent.GetComponent<Animator>().GetBool("character_nearby"))
                transform.parent.GetComponent<Animator>().SetBool("character_nearby", true);
            else
                transform.parent.GetComponent<Animator>().SetBool("character_nearby", false);
            
        }
    }
}
