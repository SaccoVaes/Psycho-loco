using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class KeyPickup : InteractablePickup
{
    public enum KeyColor { Golden, Silver, Rusty}
    public KeyColor keycolor;
    public GameObject collectable;
    // Start is called before the first frame update

    private void OnAttachedToHand(Hand hand)
    {
        //Notify's the manager to pick up the key.
        manager.AddKey(this.gameObject, keycolor);
        collectable.SetActive(true);
    }
}
