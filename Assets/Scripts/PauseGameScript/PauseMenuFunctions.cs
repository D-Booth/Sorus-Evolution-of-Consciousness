using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuFunctions : MonoBehaviour {

	public GameObject[] Panels;
	public RectTransform[] buttons = new RectTransform[2];
	int pre,post;

	public Text title;

	public int titleNum;

	public float timeDelay;

	public float buttonTimer=0;

	public bool MovePanel;

	int sign=-1;

	// Use this for initialization
	void OnEnable () {
		MovePanel = false;
		timeDelay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (MovePanel)
		{
			timeDelay += 0.05f;
			FadeOut(Panels[pre]);
			FadeIn(Panels[post]);
			if (timeDelay >= 1)
			{
				MovePanel = false;
				timeDelay = 0;
			}
		}

		if (buttonTimer >= 1)
		{
			sign = -1;
		}
		if(buttonTimer<=0){
			sign = 1;
		}

		buttonTimer = buttonTimer + (sign*0.03f);
		moveButtons();
	}

	void moveButtons(){
		if(buttons[0] != null && buttons[1] != null){
		buttons[0].localPosition = new Vector3(Mathf.Lerp(300f, 340f, buttonTimer),buttons[0].localPosition.y, buttons[0].localPosition.z);
		buttons[1].localPosition = new Vector3(Mathf.Lerp(-300f, -340f, buttonTimer),buttons[1].localPosition.y, buttons[1].localPosition.z);
		}
	}
	void FadeIn(GameObject Panel){
		CanvasGroup Alpha = Panel.GetComponent<CanvasGroup>();
		Alpha.alpha = Mathf.Lerp(0, 1, timeDelay);

		if (Alpha.alpha == 1)
		{
			Alpha.interactable = true;
		}
	}

	void FadeOut(GameObject Panel){
		CanvasGroup Alpha = Panel.GetComponent<CanvasGroup>();
		if (Alpha.alpha == 1)
		{
			Alpha.interactable = false;
		}

		Alpha.alpha = Mathf.Lerp(1, 0, timeDelay);
	}

	public void RightArrow(){
		if (!MovePanel)
		{
			if (titleNum == 0){
				pre = 0;
				post = 1;
				titleNum = 1;
				title.text = "Player Statistics";
			}
			else if (titleNum == 1){
				pre = 1;
				post = 2;
				titleNum = 2;
				title.text = "Map";
			}
			else if (titleNum == 2){
				pre = 2;
				post = 3;
				titleNum = 3;
				title.text = "Options";
			}else if (titleNum == 3){
				pre = 3;
				post = 0;
				titleNum = 0;
				title.text = "WorldStatistics";
			}
			MovePanel = true;
		}
	}

	public void LeftArrow(){
		if (!MovePanel)
		{
			if (titleNum == 0){
				pre = 0;
				post = 3;
				titleNum = 3;
				title.text = "Options";
			}
			else if (titleNum == 1){
				pre = 1;
				post = 0;
				titleNum = 0;
				title.text = "World Statistics";
			}
			else if (titleNum == 2){
				pre = 2;
				post = 1;
				titleNum = 1;
				title.text = "Player Statistics";
			}			else if (titleNum == 3){
				pre = 3;
				post = 2;
				titleNum = 2;
				title.text = "Map";
			}
			MovePanel = true;
		}
	}

	public void QuitGame(){
		#if UNITY_EDITOR	
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.QuitGame();
		#endif

		#if UNITY_STANDALONE_WIN	
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.QuitGame();
		#endif
	}
}
