using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
///     Class responsible for handling the spawning system in our game.
/// </summary>
public class SpawnManager : MonoBehaviour
{
    public enum ActionType{}
    public GameObject PrefabToSpawn;
    public ActionType type;
    public List<AudioClip> AudioclipsBackground = new List<AudioClip>();
    //bool IsreturnButton


    public void Start()
    {

    }

    public IEnumerator PlayAudio()
    {
        yield return null;
    }

}

