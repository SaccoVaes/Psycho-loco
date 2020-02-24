using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PagePickup : InteractablePickup
{
    public GameObject collectable;
    private void OnAttachedToHand(Hand hand)
    {
        manager.AddPage(this.gameObject);
        collectable.SetActive(true);
    }
}
