using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {
    public float speed = 3;
    public static bool movable = true;

    void move() {
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        if(Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
    }
    void Update() {
        if (Movements.movable) 
            move();
    }
}
