using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatistics : MonoBehaviour {

	//public single instance
	public static PlayerStatistics playerStats;

	//fuel resin power
	int MaxPowerSpheres, CurrentPowerSpheres; 

	//players HP statistics
	int currentHP, maxHP;

	//these floats are for checkpoints
	float CPX,CPY,CPZ;

	//players HealthBar
	[SerializeField]
	private Slider HealthBar;

	//power Spheres
	[SerializeField]
	private GameObject[] PowerSpheres;

	void Awake () {
		InitializePlayerStats();	
		HealthBar.maxValue = 50f;
		maxHP = 50;
		HealthBar.value = 20f;
		currentHP = 20;
		MakeInstance();
	}

	//creates singleton
	void MakeInstance(){
		if (playerStats == null)
		{
			playerStats = this;
		}
	}

	//Maximum Spheres that the player currently has
	public int GetMaxSpheres(){
		return MaxPowerSpheres;
	}
	public void SetMaxSpheres(int current){
		MaxPowerSpheres = current;
	}

	//Current Spheres that the Player currently has
	public int GetCurrentSpheres(){
		return CurrentPowerSpheres;
	}
	public void SetCurrentSpheres(int current){
		int var;
		var = CurrentPowerSpheres + current;
		//happens when you are adding to player current inventory;
		if (current > 0)
		{
			while (var > CurrentPowerSpheres)
			{
				PowerSpheres[CurrentPowerSpheres].SetActive(true);
				CurrentPowerSpheres++;
			}
		}
		else if (current < 0) // happens when you are decreasing player inventory
		{
			while (var < CurrentPowerSpheres)
			{
				PowerSpheres[CurrentPowerSpheres].SetActive(false);
				CurrentPowerSpheres--;
			}
		}

		CurrentPowerSpheres = current;
	}




	//current HP of the player
	public int GetCurrentHP(){
		return currentHP;
	}
	public void SetCurrentHP(int current){
		currentHP = current;
		changeHealthBar();
	}
	//alters healthbar
	public void changeHealthBar(){
		HealthBar.value = currentHP;
	}


	//Maximum HP of the player
	public int GetMaxHP(){
		return maxHP;
	}
	public void SetMaxHP(int current){
		maxHP = current;
		HealthBar.maxValue = maxHP;
	}


	//these are the coordinates of the checkpoints
	public float GetCheckPointX(){
		return CPX;
	}
	public float GetCheckPointY(){
		return CPY;
	}
	public float GetCheckPointZ(){
		return CPZ;
	}
	public void SetCheckPoint(float x, float y, float z){
		CPX = x;
		CPY = y;
		CPZ = z;
	}
		

	void InitializePlayerStats(){
		
	}
}
