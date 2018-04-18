using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorManager : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			Other.gameObject.transform.parent = gameObject.transform;
			//StartCoroutine(MyCoroutine());
		}
	}

	void OnCollisionExit2D (Collision2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			Other.gameObject.transform.parent = null;
		}
	}

//private IEnumerator MyCoroutine(){

	//}
}
