﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
///     Class responsible for handling the spawning system in our game.
/// </summary>
public class ButtonManager : MonoBehaviour
{
    public InventoryManager manager;
    public enum ActionType{Spawnable,MainMenu,BackButton}
    public ActionType type;
    public GameObject PrefabToSpawn;

    public void Start()
    {
       
    }

    public void OnButtonSelected()
    {
        switch (type)
        {
            case ActionType.Spawnable:
                manager.OnItemSelected(this.gameObject);
                break;
            case ActionType.MainMenu:
                manager.OnMainMenuButtonClicked(this.gameObject);
                break;
            case ActionType.BackButton:
                manager.OnBackButtonClicked();
                break;
        }
    }
}
