using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICHolder : MonoBehaviour
{
    public static bool collided = false;

    void OnCollisionEnter(Collision collision) {
         if (collision.collider.gameObject.CompareTag("ic") && !collided) {
            collision.collider.gameObject.transform.position = new Vector3(-3.6f,1.95f,-0.9f);
            ICHolder.collided = true;
            Movements.movable = false;
        }
        // Vector3(-1.82000017,-1.16789305,4.4000001)
    }
}
