using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	public void Start () {

		moveSpeed = 2f;

		print ("game has started");
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(x,y,z)
		//transform is the Player's transform... we're changing its X position continually with Time.deltaTime
		transform.Translate(
			Input.GetAxis("Horizontal")* moveSpeed * Time.deltaTime,
			Input.GetAxis("Vertical")*Time.deltaTime,
			0f);

		print(Input.GetAxis("Horizontal"));
		
	}
}
