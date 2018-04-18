using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController playerCon;

	public float PlayerSpeed;
	public bool facingRight = true;

	public bool isGrounded, isGroundedM, isGroundedF, isGroundedB,TouchingWall, PlayerHasControl;

	public float JumpForce,verticalVelocity,direction;

	public Transform groundCheck, WallCheck, groundCheckF, groundCheckB;

	Rigidbody2D RB;

	// Use this for initialization
	void Start () {
		MakeInstance();
		RB = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		isGroundedM = Physics2D.Linecast(transform.position, groundCheck.position, 1<< LayerMask.NameToLayer ("Environment"));
		isGroundedF = Physics2D.Linecast(transform.position, groundCheckF.position, 1<< LayerMask.NameToLayer ("Environment"));
		isGroundedB = Physics2D.Linecast(transform.position, groundCheckB.position, 1<< LayerMask.NameToLayer ("Environment"));

		if (isGroundedB || isGroundedF || isGroundedM){
			isGrounded = true;
		}
		else{
			isGrounded = false;
		}
		//anim.SetBool("IsGrounded", isGrounded);
		TouchingWall = Physics2D.Linecast(transform.position, WallCheck.position, 1<< LayerMask.NameToLayer ("Environment"));
		//anim.SetBool("TouchingWall", TouchingWall);
		if (PlayerHasControl)
		{
			MovePlayer();
		}

		RB.velocity = new Vector2(direction * PlayerSpeed, verticalVelocity);
	}

	//moves player
	void MovePlayer(){
		if (Input.GetButtonDown("Jump") && (isGrounded || TouchingWall))
		{
			verticalVelocity = JumpForce;
			//anim.SetBool ("IsJumping", true);
		}else{
			if (!isGrounded && Input.GetButton("Jump") && (verticalVelocity > 0))
			{
				//anim.SetBool ("IsJumping", false);
				verticalVelocity += 1.2f * -9.8f * Time.deltaTime;
			}
			else if (!isGrounded && (verticalVelocity < 0 || !Input.GetButton("Jump")))
			{
				verticalVelocity += 2.5f * -9.8f * Time.deltaTime;
			}
			else
			{
				verticalVelocity = -1f;
			}
		}
		direction = Input.GetAxis ("Horizontal");

		if ((direction > 0) && (transform.localScale.x<0)) {		//flips sprites to face opposite direction
			Flip ();
		} else if ((direction < 0) &&(transform.localScale.x>0)) {
			Flip ();
		}

		if (verticalVelocity < -100f)
		{
			verticalVelocity = -100f;
		}
	}

	//flips the sprite player
	void Flip(){
		Vector3 Local = transform.localScale;
		Local.x *= -1;
		transform.localScale = Local;
	}

	//this makes the singleton
	private void MakeInstance(){
		if (playerCon == null)
		{
			playerCon = this;
		}
	}
}
