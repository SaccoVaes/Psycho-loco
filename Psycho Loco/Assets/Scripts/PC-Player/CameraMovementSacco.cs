using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementSacco : MonoBehaviour
{
    public GameObject camerarig;
    public GameObject camera;
 private float currentZoom = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            camera.transform.Translate(0, 0, 1,Space.World);
            //Vector3 v = new Vector3();
            //camerarig.transform.Translate();
        }

        if (Input.GetKey("s"))
        {
            camera.transform.Translate(0, 0, -1,Space.World);
        }

        if (Input.GetKey("a"))
        {
            camera.transform.Translate(-1, 0, 0, Space.World);
        }

        if (Input.GetKey("d"))
        {
            camera.transform.Translate(1, 0, 0, Space.World);
        }

        //checks if the user scrolls up AKA zooming in!

        if (Input.mouseScrollDelta.y > 0 )
        {
            camera.transform.Translate(0, 0, 1,Space.Self);
        }

        //checks if the user scrolls down
        if (Input.mouseScrollDelta.y < 0 && camera.transform.rotation.eulerAngles.y <= 5.0)
        {
            camera.transform.Translate(0, 0, -1, Space.Self);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            camera.transform.Rotate(new Vector3(0,1,0),Space.World);
        }

        if (Input.GetKey(KeyCode.E))
        {
            camera.transform.Rotate(new Vector3(0, -1, 0), Space.World);
        }

        if (Input.GetKey(KeyCode.Z) && camera.transform.rotation.eulerAngles.x < 90)
        {
            camera.transform.Rotate(new Vector3(1, 0, 0), Space.World);
        }

        if (Input.GetKey(KeyCode.X)&& camera.transform.rotation.eulerAngles.x > 45)
        {
            camera.transform.Rotate(new Vector3(-1, 0, 0), Space.World);
        }


    }
    // Returns a Vector3 with only the X and Z components (Y is 0'd)
    public Vector3 vector3XZOnly(Vector3 vec)
    {
        return new Vector3(vec.x, 0f, vec.z);
    }
}
