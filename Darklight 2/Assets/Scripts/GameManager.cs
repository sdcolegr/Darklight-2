using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public TileManager tileScript;
	
	private int level = 0;
	
	void Awake() {
		if (instance == null) {
			instance = this;
		} else {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		tileScript = GetComponent<TileManager>();
		InitGame();
	}
	
	void InitGame() {
		tileScript.SetupScene(level);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
