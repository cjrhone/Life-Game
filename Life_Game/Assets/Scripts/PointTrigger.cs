using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player") 
        {
            print("POINT++");

        }
    }
}
