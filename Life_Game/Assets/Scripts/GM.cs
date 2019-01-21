using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
   [SerializeField]
    private GameObject RetryButton;
    
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject Obstacle;

    void Update() 
    {
        if (Player == null) {
            RetryButton.SetActive(true);
        }

    }
}
