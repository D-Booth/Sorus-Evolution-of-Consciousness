using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

	public GameObject[] objs; 
	public Slider MusicSlider;
	public Slider SFXSlider;

	private Animator anim;

	void Awake(){
		anim = GetComponent<Animator>();
	}

	public void LoadLevel(){
		SceneManager.LoadScene("Teris");
	}

	public void StartDemo(){
		anim.SetBool("FadeIn",true);
	}

	public void Options(){
		anim.SetBool("FadeOptions", true);
	}

	public void Credits(){
		anim.SetBool("FadeCredits", true);
	}

	public void QuitGame(){
		#if UNITY_EDITOR	
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.QuitGame();
		#endif
	}

	public void BackToMainFromOptions(){
		GameManager.manager.SetMusicMod(MusicSlider.value);
		GameManager.manager.SetSFXMod(SFXSlider.value);
		anim.SetBool("FadeOptions",false);
	}
	public void BackToMainFromCredits(){
		anim.SetBool("FadeCredits",false);
	}
}
