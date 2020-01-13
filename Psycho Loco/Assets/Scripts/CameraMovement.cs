using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
 private float currentZoom = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            camera.transform.Translate(0, 1, 0);
        }

        if (Input.GetKey("s"))
        {
            camera.transform.Translate(0, -1, 0);
        }

        if (Input.GetKey("a"))
        {
            camera.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            camera.transform.Translate(1, 0, 0);
        }

        //checks if the user scrolls up
        if (Input.mouseScrollDelta.y > 0)
        {
            camera.transform.Translate(0, 0, 1);
        }

        //checks if the user scrolls down
        if (Input.mouseScrollDelta.y < 0)
        {
            camera.transform.Translate(0, 0, -1);
        }








    }
}
