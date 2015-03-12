using UnityEngine;
using System.Collections;

public class TerrainControll : MonoBehaviour {
	
	
	
	//回転
	private float RotSpeed = 30.0f; //回転速度係数
	private float LimitRotX = 30f; //回転可能限界
	private float LimitRotZ = 30f; //回転可能限界
	
	
	//CharacterController
	private CharacterController controller;
	
	
	// Use this for initialization
	void Start () {
		//CharacterControllerを取得
		controller = GetComponent<CharacterController>();
	}
	
	void PlayerRotation(){
		
		
		//回転速度
		float RotX = 0f , RotZ = 0f;
		
		/////キー入力確認 各キーが押されているか
		if (Input.GetKey(KeyCode.LeftArrow)){
			RotZ = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow)){
			RotZ = 1f;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			RotX = -1f;
		}
		else if (Input.GetKey(KeyCode.DownArrow)){
			RotX = 1f;
		}
		
		//回転予定角度X
		float NextRotX = transform.eulerAngles.x + RotX * RotSpeed *Time.deltaTime;
		//回転予定角度z
		float NextRotZ = transform.eulerAngles.z + RotZ * RotSpeed *Time.deltaTime;
		//x方向の回転を制限  回転可能角度外
		if(NextRotX > LimitRotX && NextRotX < 10f - LimitRotX){
			//下と上のどちらから可能角度を超えたか それに応じて制限
			NextRotX = NextRotX > 10f ? 10f - LimitRotX : LimitRotX;
		}
		//z方向の回転を制限  回転可能角度外
		if(NextRotZ > LimitRotZ && NextRotZ < 10f - LimitRotZ){
			//下と上のどちらから可能角度を超えたか それに応じて制限
			NextRotZ = NextRotZ > 10f ? 10f - LimitRotZ : LimitRotZ;
		}
		
		
		
		//回転
		transform.rotation = Quaternion.Euler( 
		                                      NextRotX, 
		                                      transform.eulerAngles.z + RotZ * RotSpeed *Time.deltaTime ,
		                                      transform.eulerAngles.y
		                                      ) ;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerRotation();
		
	}
}
