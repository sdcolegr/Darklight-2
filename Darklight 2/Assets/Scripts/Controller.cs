using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]

public class Controller : MonoBehaviour {

public int direction = 2;
public float playerSpeed = 10f;
Animator anim;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator>();
		}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		
		anim.SetFloat("speed",playerSpeed);
		
		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
		{
			anim.SetBool("Walking",true);
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
			direction = 1;
			anim.SetInteger("direction",direction);
		}
		if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
		{
			anim.SetBool("Walking",true);
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
			direction = 2;
			anim.SetInteger("direction",direction);
		}
		if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
		{
			anim.SetBool("Walking",true);
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
			direction = 3;
			anim.SetInteger("direction",direction);
		}
		if(Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
		{
			
			anim.SetBool("Walking",true);
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
			direction = 4;
			anim.SetInteger("direction",direction);
			
				
			
		}
		Debug.Log(direction);
		
		if(!Input.anyKey)
			anim.SetBool("Walking",false);
	}
}
