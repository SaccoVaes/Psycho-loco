﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
///     Script for 
/// </summary>
public class InventoryManager : MonoBehaviour
{
    public List<GameObject> InventoryItems = new List<GameObject>();
    public GameObject SelectedItem;
    public SpawnManager SelectedManager;

    void Start()
    {
        ActivateHotkeys();
    }
    
    // Update is called once per frame
    void Update()
    {
        //Check if List is not empty
        if (InventoryItems.Count != 0)
        {
            for(int i = 0; i < InventoryItems.Count; i++)
            {
                if (Input.GetKeyDown((i + 1).ToString()))
                {
                    OnItemSelected(InventoryItems[i]);
                }
            }
        }

        //If the user presses left button.
        if (Input.GetMouseButtonDown(0))
        {
            if(SelectedItem != null)
            {
                SpawnItem(SelectedItem);
                SelectedItem.GetComponent<Image>().color = Color.white;
                SelectedItem = null;
            }
        }
    }

    //Method for generating hotkeys.
    public void ActivateHotkeys()
    {
        if (InventoryItems.Count != 0)
        {
            //For x items in the list.
            for (int i = 0; i < InventoryItems.Count; i++)
            {
                //Get the required text components in the children.
                var text = InventoryItems[i].GetComponentInChildren<Text>();
                text.text = (i + 1).ToString();

                var button = InventoryItems[i].GetComponent<Button>();
                button.onClick.AddListener(delegate { OnItemSelected(button.gameObject);
                });

            }
        }
    }

    public void SpawnItem(GameObject go)
    {
        var spawnmanager = go.GetComponent<SpawnManager>();
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            Debug.Log("You selected the " + hit.transform.name);
            Debug.Log("Spawning " + hit.transform);
            Instantiate(spawnmanager.PrefabToSpawn, hit.transform);
        }
    }

    public void OnItemSelected(GameObject item)
    {
        //Deselect the old item.
        if (SelectedItem != null)
        {
            SelectedItem.GetComponent<Image>().color = Color.white;
        }

        //Check if the same item is already selected;
        if (SelectedItem == item)
        {
            SelectedItem.GetComponent<Image>().color = Color.white;
            SelectedItem = null;
            return;
        }
        //Select new item to green;
            SelectedItem = item;
            SelectedItem.GetComponent<Image>().color = Color.green;
    }

}
