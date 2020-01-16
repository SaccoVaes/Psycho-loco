using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Class responsible for handling the spawning system in our game.
/// </summary>
public class SpawnManager : MonoBehaviour, IPointerClickHandler
{
    public InventoryManager InventoryMaster;
    public void OnPointerClick(PointerEventData eventData)
    {
        var item = InventoryMaster.SelectedItem;
        
        //throw new System.NotImplementedException();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
