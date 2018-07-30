﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	[SerializeField] float screenWidthInUnits = 16f;
	[SerializeField] float max = 15f;
	[SerializeField] float min = 1f;


	// Use this for initialization
	void Start () {
		//make cursor invisible
		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () {
		//Getting mouse position as a amount in screen units
		float mouseXPos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		//Debug.Log(mouseXPos);
		//Debug.Log(Input.mousePosition.x);
		//new vector that makes paddle where mouse x is
		Vector2 paddlePos = new Vector2(transform.position.x , transform.position.y);
		paddlePos.x = Mathf.Clamp(mouseXPos - 3.3f, min, max);
		paddlePos.y = -6.25f;


		transform.position = paddlePos;
	}

}
