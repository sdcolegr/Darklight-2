using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadOnClick : MonoBehaviour {
	public GameObject loadingImage;
	
	public void LoadScene(int wave) {
		loadingImage.SetActive(true);
		SceneManager.LoadScene (wave);	
	}
}
