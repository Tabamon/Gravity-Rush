using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTrigger : MonoBehaviour
{

    public GameObject ship;
    public GameObject explosion;
    public AudioSource explosionAudio;
    bool alreadyExploded = false;

    // if player enters trigger then do not activate trigger again. And set ship as active
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ThirdPersonController_LITE" && !alreadyExploded)
        {
            alreadyExploded = true;
            StartCoroutine(animation());
        }
    }

    IEnumerator animation()
    {
        explosionAudio.Play();
        yield return new WaitForSeconds(0.7f);
        ship.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        explosion.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Destroy(ship);
        yield return new WaitForSeconds(3.7f);
        Destroy(explosion);
    }
}
