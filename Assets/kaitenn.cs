using UnityEngine;
using System.Collections;

public class kaitenn : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown("up")){
		  }
		if(Input.GetKeyDown("down")){
		}
		// 水平方向の入力量(-1〜1)
		float horizontal = Input.GetAxis("Horizontal");
		
		// 垂直方向の入力量(-1〜1)
		float vertical = Input.GetAxis("Vertical");
		ver rotation =Quaternion.Euler(y,x,0)

			transform.RotateAround(new Vector3 (1, 0, 1), transform.up, 45*Time.deltaTime);
	}
	
	}

}
