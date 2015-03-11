using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public Vector3 acceleration;	// 加速度
	
	void FixedUpdate () {
		// 加速度与える
	rigidbody.AddForce(acceleration, ForceMode.Acceleration);
	}
	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, 9.81f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
