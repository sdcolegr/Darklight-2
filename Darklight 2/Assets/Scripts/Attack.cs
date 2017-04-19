using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	
	public GameObject[] enemies;
	private float attackTimer;
	public float cooldown = 0.3f;
	public int damage;
	
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		damage  = 25;
		AddEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0) attackTimer -= Time.deltaTime;
		if (attackTimer < 0) attackTimer = 0;
		if (Input.GetKeyUp(KeyCode.Z) && attackTimer == 0) {
			for (int i = 0; i < enemies.Length; i++) {
				float enemyDistance = Vector2.Distance(enemies[i].transform.position, transform.position);
				if (enemyDistance < 1.5f) {
					ApplyDamage(enemies[i]);
					attackTimer = cooldown;
				}
			}
		}
	}
	
	public void AddEnemies() {
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
	} 
	
	void ApplyDamage(GameObject enemy) {
		enemy.SendMessage("SubtractEnemyHealth", damage, SendMessageOptions.RequireReceiver);
	}
}
