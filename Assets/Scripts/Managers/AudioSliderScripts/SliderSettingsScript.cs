using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSettingsScript : MonoBehaviour {

	[SerializeField]
	Slider musicSlider, SFXSlider;

	[SerializeField]
	AudioClip SFXSample;

	public void MusicSlider(){
		GameManager.manager.SetMusicMod(musicSlider.value);
	}

	public void SFX_Slider(){
		GameManager.manager.SetSFXMod(SFXSlider.value);

		AudioSource.PlayClipAtPoint(SFXSample, transform.position,SFXSlider.value);
	}
}
