using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public static CameraController camController;

	public GameObject Player;
	public float cameraSpeed;
	float CameraSize;

	private Vector3 CamOffset;

	private bool followPlayer;

	Transform variablePos;

	Camera MainCam;

	// Use this for initialization
	void Awake () {
		MakeInstince();
		MainCam = GetComponent<Camera>();
		MainCam.orthographicSize = 6;
		InitializeCamera();
		followPlayer = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (followPlayer){
			FollowPlayer();
		}else{
			GoToTransform();
		}
		
	}

	void MakeInstince(){
		if (camController == null)
		{
			camController = this;
		}
	}
		
	void FollowPlayer(){
		Vector3 playerOffset = Player.transform.position;

		playerOffset = new Vector3(playerOffset.x, playerOffset.y+3f, -10);

		Vector3 currentVector = playerOffset - transform.position;

		transform.Translate(currentVector * Time.deltaTime * cameraSpeed);
	}

	void GoToTransform(){
		Vector3 currentVector = variablePos.position - transform.position;
		transform.Translate(currentVector * Time.deltaTime * cameraSpeed);
	}

	void InitializeCamera(){
		transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y, -10);
	}

	//public float GetTransform(){
		//return variablePos;
	//}

	public void SetTransform(Transform UpdatedPos){
		variablePos = UpdatedPos;
	}

	public float GetCamSize(){
		return CameraSize;
	}
	public void SetCamSize(float newSize){
		CameraSize = newSize;
	}
}
