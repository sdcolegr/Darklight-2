using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {
	
	public int damage;
	
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.CompareTag("Enemy"))
			col.gameObject.SendMessage("SubtractEnemyHealth", damage, SendMessageOptions.RequireReceiver);
	}
}
