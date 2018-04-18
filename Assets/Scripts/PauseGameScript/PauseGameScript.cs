using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour {

	public float timer;

	private bool paused = false;

	public GameObject PauseMenu;

	public KeyCode EscapeKey;

	void Awake(){

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(EscapeKey))
		{
			paused = !paused;
		}

		if (paused)
		{
			PauseMenu.SetActive(true);
			Time.timeScale = 0;
		}
		else
		{
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
		timer = Time.time;
	}
}
