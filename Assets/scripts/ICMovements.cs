using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICMovements : MonoBehaviour {
    public float speed = 3;
    public static bool movable = true;

    void move() {
        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.4f)
            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.4f )
            transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
        if(Input.GetKey(KeyCode.DownArrow) && transform.position.z > -3.4f)
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        if(Input.GetKey(KeyCode.UpArrow) && transform.position.z < 5f)
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        if(Input.GetKey(KeyCode.W) && transform.position.y < 3.8f)
            transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
    }

    void start() {
        Debug.Log("hello");
    }

    void Update() {
        if (ICMovements.movable && !Switch.ICLocked) 
            this.move();
    }
}
