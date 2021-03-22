using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public GameObject toDestroy;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "titaniun-fighter")
            Destroy(toDestroy);
    }
}
