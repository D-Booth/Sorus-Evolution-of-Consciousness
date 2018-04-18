using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelResinScript : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			int var = PlayerStatistics.playerStats.GetMaxSpheres()+1;
			int cVar = PlayerStatistics.playerStats.GetCurrentSpheres();
			if (var < 8)
			{
				PlayerStatistics.playerStats.SetMaxSpheres(var);
				PlayerStatistics.playerStats.SetCurrentSpheres(var - cVar);
			}
			gameObject.SetActive(false);
		}
	}
}
