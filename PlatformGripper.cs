using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject player;
    public GameObject ledge;
    public GameObject camera;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ThirdPersonController_LITE")
        {
            player.transform.parent = ledge.transform;
            camera.transform.parent = ledge.transform;
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "ThirdPersonController_LITE")
        {
            player.transform.parent = null;
            camera.transform.parent = null;
        }
    }
}
