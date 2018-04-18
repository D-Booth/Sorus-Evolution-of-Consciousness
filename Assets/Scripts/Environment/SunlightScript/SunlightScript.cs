using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunlightScript : MonoBehaviour {
	BoxCollider2D Box;

	// Use this for initialization
	void Start () {
		Box = GetComponent<BoxCollider2D>();
	}

	void OnTriggerEnter2D(Collider2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			PlayerController.playerCon.PlayerSpeed = 7f;
			PlayerController.playerCon.JumpForce = 10f;
			PlayerStatistics.playerStats.SetCurrentHP(PlayerStatistics.playerStats.GetMaxHP());
			Box.enabled = false;
		}
	}
}
