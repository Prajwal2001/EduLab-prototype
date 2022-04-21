using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
        if (gameObject.tag == "ic_lock_switch") {
            if (ICHolder.collided && Movements.movable) Movements.movable = !Movements.movable;
        }
    }
}
