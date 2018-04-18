using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFallingRocks : MonoBehaviour {

	public Rigidbody2D[] rocks;

	public float seconds;

	void OnTriggerEnter2D(Collider2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			StartCoroutine(MyCoroutine());
		}
	}
		
	private IEnumerator MyCoroutine(){
		int i = 0;
		while (i < 4)
		{
			yield return new WaitForSeconds(seconds);
			rocks[i].bodyType = RigidbodyType2D.Dynamic;
			i++;
		}
		yield return new WaitForSeconds(seconds);
		gameObject.SetActive(false);
	}
}
