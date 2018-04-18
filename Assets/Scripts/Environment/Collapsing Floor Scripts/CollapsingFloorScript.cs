using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingFloorScript : MonoBehaviour {

	float seconds = 1;

	void OnCollisionEnter2D(Collision2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			StartCoroutine(MyCoroutine());
		}
	}

	private IEnumerator MyCoroutine(){
		yield return new WaitForSeconds(seconds);
		Destroy(gameObject);
	}
}

