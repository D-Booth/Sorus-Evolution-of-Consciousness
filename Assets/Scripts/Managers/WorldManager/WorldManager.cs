using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour {

	public static WorldManager terisManager;
	public GameObject[] worldOBJS;
	bool[] CheckDestroyState;

	float GamePlayTimer;


	void Awake(){
		MakeInstance();
	}

	//create instance of terisManager
	void MakeInstance(){
		if (terisManager == null)
		{
			terisManager = this;
		}
	}

	//getters and setters for the world Objects
	public GameObject[] GetWorldOBJS(){
		return worldOBJS;
	}
	public void SetWorldOBJS(GameObject[] data){
		worldOBJS = data;
	}

	//getters and setter for Checking if object has been destroyed or not
	public bool[] GetDestroyState(){
		return CheckDestroyState;
	}
	public void SetDestroyState(int element, bool ActiveState){ //be careful with this you only assign one element at a time
		CheckDestroyState[element] = ActiveState;
	}
	public void SetAllDestroyState(bool[] array){//this will be for saving/loading purposes
		CheckDestroyState = array;
	}

}
