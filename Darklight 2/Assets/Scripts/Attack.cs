using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	
	public GameObject[] enemies;
	private float attackTimer;
	public float cooldown = 0.3f;
	public int damage;
	Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attackTimer = 0;
		damage  = 25;
		AddEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0) attackTimer -= Time.deltaTime;
		if (attackTimer < 0) attackTimer = 0;
		
		//attacking garbage
		 if(Input.GetKeyDown(KeyCode.Z)){
             anim.SetBool("Attacking",true);
             //play attack
         }
		
		if (Input.GetKeyUp(KeyCode.Z) && attackTimer == 0) {
			anim.SetBool("Attacking",false);
			attackTimer = cooldown;
		}
	}
	
	public void AddEnemies() {
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
	} 
}
