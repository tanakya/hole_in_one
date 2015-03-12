using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform Player;
	Vector3 relativePosition;
	
	void Start () {
		relativePosition = transform.position - Player.position;
	}
	
	void LateUpdate () {
		transform.position = Player.position + relativePosition;
	}
}