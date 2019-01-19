using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    //SerialzedField tells Unity to expose only in the Unity editor, but is still private
    [SerializeField]
    private GameObject RetryButton;
    
    [SerializeField]
    private GameObject Player;

    // used without trigger. Needs rigidbody. 
    void OnCollisionEnter(Collision col) {
        //null check
        if(RetryButton != null){
            RetryButton.SetActive(true);
        }
        print("OnCollision collision");
        if(Player)
        {
        print("Destroy Player");
        Destroy(Player);
        }
    }

    // Triggers are checkpoints and events, physically they're usually empty objects
    // Needs rigidbody 
    //  void OnTriggerEnter(Collider col) {
    
    //     print("OnTrigger collision");
    //     Destroy(col.gameObject);
    // }

    // void Destruction() {
    //     Destroy(this.gameObject);
    //     print("Boom! GOT EM");
    // }
}
