using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSword : MonoBehaviour {
	
	public int damage;
	
	void Start() {
		damage = 10;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.CompareTag("Enemy"))
			col.gameObject.SendMessage("SubtractEnemyHealth", damage, SendMessageOptions.RequireReceiver);
	}
}
