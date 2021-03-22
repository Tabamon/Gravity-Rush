using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGravityBox : MonoBehaviour
{

    public float gravityValue = 2.5f;
    public AudioSource enterAudio;
    public AudioSource exitAudio;

    void OnTriggerEnter(Collider other)
    {
        // if the player enters the area then change gravity and play sound
        if (other.gameObject.name == "ThirdPersonController_LITE")
        {
            Physics.gravity = new Vector3(0, gravityValue, 0);
            enterAudio.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // if the player enters the area then change gravity and play sound
        if (other.gameObject.name == "ThirdPersonController_LITE")
        {
            Physics.gravity = new Vector3(0, -1.0f, 0);
            exitAudio.Play();
        }
    }

}
