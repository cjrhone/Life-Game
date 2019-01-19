using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

        void OnTriggerEnter(Collider coll) 
        {
            print("OnTrigger Collision");
            Destroy(coll.gameObject);
        }
}
    // public float lifeTime = 10f;

    // Update is called once per frame
    // void Update()
    // {
    //     if(lifeTime > 0) {
    //         lifeTime -= Time.deltaTime; //decreasing our lifetime if greater than 0
    //         if(lifeTime <= 0) {
    //             Destruction();
    //         }
    //     }

    //     if(this.transform.position.y <= -10) {
    //         Destruction();
    //     }
        
    // }

