using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingMeteor : MonoBehaviour
{

    public AudioSource FallingMeteorSound = null;
    bool beingHandled = false;
    // Update is called once per frame
    void Update()
    {
        if (!beingHandled)
            StartCoroutine(fallingChance());
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }

    IEnumerator fallingChance()
    {
        beingHandled = true;
        yield return new WaitForSeconds(3);
        int rand = Random.Range(1,100);
        if (rand < 20)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            FallingMeteorSound.Play();
        }
        beingHandled = false;
    }
}
