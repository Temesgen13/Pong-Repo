using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization

	private int xdirection = -1;
	private int zdirection = 0;

	public Paddle player;
	public AIPaddle computer;

	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x +.05f * xdirection,0,  this.transform.position.z+zdirection*.05f);

		player.transform.position = new Vector3 (-4,0,this.transform.position.z);
		computer.transform.position = new Vector3 (4,0,this.transform.position.z);
	}

	void OnTriggerEnter( Collider collider){
		if(collider.tag=="playerPaddle"){
			xdirection *= -1;

			if (Random.Range (0.0f, 100f) > 50) {
				zdirection = -1;
			} else {
				zdirection = 1;
			}

			}

		if(collider.tag=="Wall"){
			zdirection *= -1;
		}
	
		Debug.Log (collider.tag);
	}


}
