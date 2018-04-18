using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			int var = PlayerStatistics.playerStats.GetCurrentHP();
			int mVar = PlayerStatistics.playerStats.GetMaxHP();
			if ((var + 10) < mVar)
			{
				PlayerStatistics.playerStats.SetCurrentHP(var + 10);
			}
			else
			{
				PlayerStatistics.playerStats.SetCurrentHP(mVar);
			}
			Destroy(gameObject);
		}
	}
}
