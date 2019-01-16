using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    // void OnCollisionEnter(Collision col) {
    
    //     print("OnCollision collision");
    // }

     void OnTriggerEnter(Collider col) {
    
        print("OnTrigger collision");
        Destroy(col.gameObject);
    }

    // void Destruction() {
    //     Destroy(this.gameObject);
    //     print("Boom! GOT EM");
    // }
}
