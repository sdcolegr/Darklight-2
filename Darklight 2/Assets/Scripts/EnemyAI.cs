using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public GameObject player;
	public float speed = 2f;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed*Time.deltaTime);
	}
}
