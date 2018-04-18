using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableWall : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D Other){
		if(Other.gameObject.CompareTag("Player")){
			gameObject.SetActive(false);
		}
	}
}
