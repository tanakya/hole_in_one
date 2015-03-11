using UnityEngine;
using System.Collections;

public class ballspeed : MonoBehaviour {
	//最大速度
	public float maxVelocity = 30f;
	//最大速度の２乗
	public float maxSqrVelocity;
	
	void Start () {
		//最大速度の２乗を求めておく
		maxSqrVelocity = maxVelocity * maxVelocity;
	}

	void FixedUpdate(){
		//速度チェック
		if (rigidbody.velocity.sqrMagnitude > maxSqrVelocity) {
			//物理オブジェクトの速度をmaxVelocityで指定した最大速度にする
			rigidbody.velocity = rigidbody.velocity.normalized * maxVelocity;
		}
	}
}
