using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour {

	public static GameManager manager;
	float SFXModifier, MusicModifier;

	// Use this for initialization
	void Awake () {
        SFXModifier = MusicModifier = 0f;
		MakeSingleton();
	}

	//this creates and sustains the singleton
	void MakeSingleton(){
		if (manager == null)
		{
			DontDestroyOnLoad(gameObject);
			manager = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void SetSFXMod(float var){
		SFXModifier = var;
	}
	public void SetMusicMod(float var){
		MusicModifier = var;
	}

	public float GetSFXMod(){
		return SFXModifier;
	}
	public float GetMusicMod(){
		return MusicModifier;
	}


	//these functions will be used for saving 
	public void SaveGame(){
		//BinaryFormatter bf = new BinaryFormatter();
		//FileStream file = File.Create(Application.persistentDataPath + "/SorusData.EVO");

		//SaveAbleData Data = new SaveAbleData();

		//ClassVar.variable = getdata

		//bf.Serialize(file, ClassVar);

		//file.Close();
	}

	public void LoadGame(){
		if (File.Exists(Application.persistentDataPath + "/SorusData.EVO"))
		{
			//BinaryFormatter bf = new BinaryFormatter();
			//FileStream file = File.Open(Application.persistentDataPath + "/SorusData.EVO", FileMode.Open);
			//className ClassVar = (ClassName)bf.Deserialize(file);
			//file.Close();

			//reassign variable data to appropriate info
		}
	}
}

[Serializable]
public class SaveAbleData{
	public PlayerStatistics playerStats;
	public WorldManager terisManager;
}

