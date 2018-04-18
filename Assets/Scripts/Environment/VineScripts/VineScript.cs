using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			HingeJoint2D Hinge = GetComponent<HingeJoint2D>();
			Hinge.enabled = false;
			Destroy(gameObject);
		}
	}
}
