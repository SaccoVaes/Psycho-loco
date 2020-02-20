using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PagePickup : InteractablePickup
{
    private void OnAttachedToHand(Hand hand)
    {
        manager.AddPage(this.gameObject);
    }
}
