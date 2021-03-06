﻿using UnityEngine;
using System.Collections;

public class PlayerMove: MonoBehaviour {

	private int xPosition;

	void Update () {
		if(Input.GetButtonDown("Horizontal")) {
			if (Input.GetAxis ("Horizontal") > 0) {
				xPosition++;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				xPosition--;
			}
		}

		MovePlayer ();
	}

	void MovePlayer() {
		var position = gameObject.transform.position;
		position.x = xPosition;
		gameObject.transform.position = Vector2.Lerp (gameObject.transform.position, position, 10 * Time.deltaTime);
	}
}
