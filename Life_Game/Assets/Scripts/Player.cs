﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        print("Hello There");
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(x,y,z)
       transform.Translate(
        Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 
        Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed, 
        0f);
        
    }
    //   void OnCollisionEnter(Collision coll) {
    //     if(coll.gameObject.name == "Obstacle") {
    //         print("Collide");
    //         Destruction();
    //         print("Destruction");
    //     }
    // }

//     void Destruction() {
//         Destroy(this.gameObject);
//         print("BOOM!");
//     }
 }
