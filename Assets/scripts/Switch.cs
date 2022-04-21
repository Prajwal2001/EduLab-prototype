using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public static bool ICLocked = false;
    void OnMouseDown()
    {
        if (gameObject.tag == "ic_lock_switch" && ICHolder.collided) {
            print("IC collided: " + ICHolder.collided);
            transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
            ICMovements.movable = !ICMovements.movable;
            Switch.ICLocked = !Switch.ICLocked;
            GameObject.FindGameObjectsWithTag("ic")[0].transform.position = new Vector3(-3.6f,1.83f,-0.9f);
        } else if (gameObject.tag == "input_switch") transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
    }
}
