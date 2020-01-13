using System.Collections;
using System.Collections.Generic;
using Valve.VR;
using UnityEngine;

/// <summary>
/// Class responsible for the behaviour of the flashlight
/// </summary>
public class VR_Player_Flashlight : MonoBehaviour
{
    public SteamVR_Behaviour_Pose pose;
    public SteamVR_Action_Boolean ActivateMovement = SteamVR_Input.GetBooleanAction("InteractUI");
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (pose == null)
            pose = this.GetComponent<SteamVR_Behaviour_Pose>();
        if (pose == null)
            Debug.LogError("No SteamVR_Behaviour_Pose component found on this object");
        if (ActivateMovement == null)
            Debug.LogError("No ui interaction action has been set on this component.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
