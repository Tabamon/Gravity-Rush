using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour
{

    public AudioSource hitSound;
    public int penaltyScore = -400;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ThirdPersonController_LITE")
        {
            GlobalScore.currentScore += penaltyScore;
            hitSound.Play();
        }
    }

}
