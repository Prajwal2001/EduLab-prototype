using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICHolder : MonoBehaviour
{
    public static bool collided = false;

    void OnCollisionEnter(Collision collision) {
         if (collision.collider.gameObject.CompareTag("ic") && !ICHolder.collided) {
            collision.collider.gameObject.transform.position = new Vector3(-3.6f,1.83f,-0.9f);
            ICHolder.collided = true;
        }
    }

     void OnCollisionExit(Collision collision) {
         if (collision.collider.gameObject.CompareTag("ic")) 
            ICHolder.collided = false;
     }
}
