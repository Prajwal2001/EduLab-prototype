using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovements : MonoBehaviour
{

    bool updated = false;
    // Update is called once per frame
    void Update()
    {
        if (ICHolder.collided && !updated) {
            transform.position = new Vector3(0f,9.92000008f,0.7000006f);
            transform.Rotate(60.0f, 0.0f, 0.0f, Space.Self);
            updated = true;
        }
    }
}
