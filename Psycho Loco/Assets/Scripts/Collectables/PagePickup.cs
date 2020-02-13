using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable))]
public class PagePickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnAttachedToHand(Hand hand)
    {
        Destroy(this.gameObject);
    }
}
