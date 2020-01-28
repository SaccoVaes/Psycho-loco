using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Class responsible for handling the spawning system in our game.
/// </summary>
public class SpawnManager : MonoBehaviour
{
    public enum ActionType{Audio,Spawnable}
    public GameObject PrefabToSpawn;
    public ActionType type; 


    public void Start()
    {
        switch (type)
        {
            case ActionType.Audio:

                break;
            case ActionType.Spawnable:

                break;
        }
    }

    public IEnumerator PlayAudio()
    {
        yield return null;
    }
}
