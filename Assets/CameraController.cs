using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform Terrain;
	Vector3 relativePosition;
	
	void Start () {
		relativePosition = transform.position - Terrain.position;
	}
	
	void LateUpdate () {
		transform.position = Terrain.position + relativePosition;
	}
}