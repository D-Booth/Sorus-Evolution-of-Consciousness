using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableRock : MonoBehaviour {

	void OnCollisionStay2D(Collision2D Other){
		if(Other.gameObject.CompareTag("Player")&&PlayerController.playerCon.isGrounded){
			Rigidbody2D RB = GetComponent<Rigidbody2D>();
			Rigidbody2D OtherRB = GetComponent<Rigidbody2D>();
			PlayerController.playerCon.PlayerSpeed = 2;
			RB.velocity = new Vector2(OtherRB.velocity.x,0);
		}
	}
	void OnCollisionExit2D(Collision2D Other){
		if (Other.gameObject.CompareTag("Player"))
		{
			PlayerController.playerCon.PlayerSpeed = 7;
		}
	}
}
