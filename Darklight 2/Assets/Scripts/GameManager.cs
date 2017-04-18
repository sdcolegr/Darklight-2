﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public TileManager tileScript;
	public WaveManager waveScript;

	private int wave = 1;
	
	void Awake() {
		if (instance == null) {
			instance = this;
		} else {
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		tileScript = GetComponent<TileManager>();
		waveScript = GetComponent<WaveManager>();
		InitGame();
	}
	
	void InitGame() {
		waveScript.setupWave(wave);
		tileScript.SetupScene(wave);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
