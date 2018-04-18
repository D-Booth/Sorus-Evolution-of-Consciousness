using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D Other){
		if (Other.gameObject.CompareTag("EnvironmentDamage"))
		{
			if (Other.gameObject.GetComponent<EnvironmentDamageScript>())
			{
				EnvironmentDamageScript script = Other.gameObject.GetComponent<EnvironmentDamageScript>();
				int var = PlayerStatistics.playerStats.GetCurrentHP();
				PlayerStatistics.playerStats.SetCurrentHP(script.damage + var);
			}
		}
	}
}
