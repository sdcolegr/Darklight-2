using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]

public class Controller : MonoBehaviour {

public int direction = 2;
public float playerSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
			direction = 1;
		}
		if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
			direction = 2;
		}
		if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
			direction = 3;
		}
		if(Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
			direction = 4;
		}
		Debug.Log(direction);
	}
}
