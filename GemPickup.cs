using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemPickup : MonoBehaviour
{

    public GameObject ScoreBox;
    public AudioSource PickupSound;
    public int gemScore = 1000;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ThirdPersonController_LITE")
        {
            GlobalScore.currentScore += gemScore;
            // ScoreBox.GetComponent<Text>().text = "1000";
            PickupSound.Play();
            Destroy(gameObject);
        }
    }


}
