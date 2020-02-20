using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

/// <summary>
/// This Class is responsible for holding all information of the found collectables.
/// </summary>
public class InteractableManager : MonoBehaviour
{
    public List<GameObject> pages = new List<GameObject>();
    public bool HasGoldenKey;
    public bool HasSilverKey;
    public bool HasRustyKey;
    public bool IsPowerSwitchOn;

    //References to the locks
    public GameObject GoldenLock;
    public GameObject SilverLock;
    public GameObject RustyLock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddPage(GameObject page)
    {
        Debug.Log("Test");
        //Adds the page to the collection.
        pages.Add(page);
        //Destroys the game object.
        Destroy(page);
        //Updates HUD?
    }

    public void AddKey(GameObject key, KeyPickup.KeyColor color)
    {
        switch(color)
        {
            case KeyPickup.KeyColor.Golden:
                HasGoldenKey = true;
                GoldenLock.GetComponentInChildren<LockOpen>().enabled = true;
                Destroy(key);
                //TODO Show key on hud?
                break;
            case KeyPickup.KeyColor.Silver:
                HasSilverKey = true;
                SilverLock.GetComponentInChildren<LockOpen>().enabled = true;
                Destroy(key);
                //TODO Show key on hud?
                break;
            case KeyPickup.KeyColor.Rusty:
                HasRustyKey = true;
                RustyLock.GetComponentInChildren<LockOpen>().enabled = true;
                Destroy(key);
                //TODO Show key on hud?
                break;
        }
    }

}
