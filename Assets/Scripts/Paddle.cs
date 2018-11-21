using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w") && this.transform.position.z < 4.5){
		
			this.transform.position = new Vector3 (this.transform.position.x, 0, this.transform.position.z + speed);
		}
		if(Input.GetKey("s") && this.transform.position.z > -4.5){

			this.transform.position = new Vector3 (this.transform.position.x, 0, this.transform.position.z - speed);
		}
		if(this.transform.position.z > 4.5){

			this.transform.position = new Vector3 (this.transform.position.x, 0, 4.5f);
		}
	
		if(this.transform.position.z < -4.5){

			this.transform.position = new Vector3 (this.transform.position.x, 0, -4.5f);
		}
	}
}
