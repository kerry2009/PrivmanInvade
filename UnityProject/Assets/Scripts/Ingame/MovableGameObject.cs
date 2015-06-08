﻿using UnityEngine;
using System.Collections;

public class MovableGameObject : MonoBehaviour {
	public float moveXSpeed = 0f;
	public float moveYSpeed = 0f;
	public bool isDead = false;
	
	// Update is called once per frame
	void Update () {
		OnUpdate ();
	}

	protected virtual void OnUpdate() {
		Vector3 tranPos = transform.position;
		tranPos.x += moveXSpeed;
		tranPos.y += moveYSpeed;
		transform.position = tranPos;
	}
}
