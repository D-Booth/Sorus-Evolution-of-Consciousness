using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

	public static PlayerRotation RotationCon;

	public float rayLength;

	public LayerMask Environment;

	public float zAngle=0.0f;
	void Awake () {
		MakeSingleton();
	}

	void FixedUpdate () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, 1 << LayerMask.NameToLayer("Environment"));
		if (hit)//you need this hit check before the comparetag
		{		//this is due to the fact that "hit" can be null and the first check determines if hit is not null
			if (hit.collider.CompareTag("Environment"))
			{
				zAngle = -(Mathf.Atan2(hit.normal.x, hit.normal.y) * Mathf.Rad2Deg);
			}
			transform.eulerAngles = new Vector3(0, 0, zAngle);
		}
	}

	void MakeSingleton(){
		if (RotationCon == null)
		{
			RotationCon = this;
		}
		else if (RotationCon != null)
		{
			Destroy(gameObject);
		}
	}
}
	