using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModifier : MonoBehaviour {

	AudioSource Music;
    float musicModCheck;



	void Start(){
		Music = GetComponent<AudioSource>();
        if (!Music.isPlaying)
        {
            musicModCheck = Music.volume = GameManager.manager.GetMusicMod();
            Music.Play();
        }
	}

    void Update()
    {
        if (musicModCheck != GameManager.manager.GetMusicMod())
        {
            Music.volume = GameManager.manager.GetMusicMod();
        }
    }

}
