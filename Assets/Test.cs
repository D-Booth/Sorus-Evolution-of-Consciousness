using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	Image fillAlpha;

	public float num;

	// Use this for initialization
	void Start () {
		fillAlpha = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
		{
			fillAlpha.color = new Color(fillAlpha.color.r, fillAlpha.color.g, fillAlpha.color.b, fillAlpha.color.a - (0.015f));

		}

		if (!Input.GetButton("Fire1"))
		{
			fillAlpha.color = new Color(fillAlpha.color.r, fillAlpha.color.g, fillAlpha.color.b, fillAlpha.color.a + (0.015f));
		}
		num = fillAlpha.color.a;
		
	}
}
