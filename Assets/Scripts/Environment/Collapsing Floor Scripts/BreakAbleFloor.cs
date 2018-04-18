using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAbleFloor : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Other){
		if (Other.gameObject.name == "PushableRock")
		{
			Other.gameObject.SetActive(false);
			gameObject.SetActive(false);
		}
	}
}
