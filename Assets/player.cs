using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
	
	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	
	//Collision Detection
	void OnControllerColliderHit (ControllerColliderHit charctor){
		if(charctor.collider.gameObject.name == "Goal"){
			Debug.Log ("Goal");
			text.enabled = true;
		}
	}
	
}

