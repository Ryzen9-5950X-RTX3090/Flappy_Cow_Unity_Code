using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Click () {
		SceneManager.LoadScene ("game");
	}

	// Update is called once per frame

}
