using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	
	public GameObject enemy;
	public float enemyDistance;
	private float attackTimer;
	public float cooldown = 0.3f;
	public int damage;
	
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		damage  = 25;
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0) attackTimer -= Time.deltaTime;
		if (attackTimer < 0) attackTimer = 0;
		if (Input.GetKeyUp(KeyCode.Z) && attackTimer == 0) {
			enemyDistance = Vector2.Distance(enemy.transform.position, transform.position);
			if (enemyDistance <= 2) {
				ApplyDamage();
				attackTimer = cooldown;
			}
		}
	}
	
	void ApplyDamage() {
		enemy.SendMessage("SubtractEnemyHealth", damage, SendMessageOptions.RequireReceiver);
	}
}
