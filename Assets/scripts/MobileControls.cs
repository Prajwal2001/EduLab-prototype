using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControls : MonoBehaviour
{
    public float speed = 15;
    public static bool isEnabled = false;
    string[] names = {"darkArrow_up", "darkArrow_down", "darkArrow_left", "darkArrow_right", "darkArrow_up2", "darkArrow_down2"};

    void Update() {
         //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                    // print(raycastHit.transform.gameObject.tag);
                }
            }
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject) {
        if(gameObject.tag == "ic") {
            isEnabled = !isEnabled;
            // print(names.Length);
            foreach(string name in names)
                // print(tag);
                GameObject.Find(name).transform.localScale = isEnabled ? new Vector3(0.3f, 0.3f, 1) : new Vector3(0f, 0f, 0f);
        }
        if (ICMovements.movable && !Switch.ICLocked){
            if(gameObject.tag=="right_arrow" && transform.position.x < 9.4f) {
                transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
                print("Right button");
            }
            if(gameObject.tag=="left_arrow" && transform.position.x > -9.4f )
                transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
            if(gameObject.tag=="down_arrow" && transform.position.z > -3.4f)
                transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
            if(gameObject.tag=="up_arrow" && transform.position.z < 5f)
                transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
            if(gameObject.tag=="W" && transform.position.y < 3.8f)
                transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
            if(gameObject.tag=="S")
                transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
        }
    }
}
