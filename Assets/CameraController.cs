﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject Terrain;
	private Vector3 offset;

	void Start () {
		offset = transform.position;
	}
	
	void LateUpdate () {
		transform.position = Terrain.transform.position + offset;
	}
}