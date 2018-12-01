using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization

	private int xdirection = -1;
	private int zdirection = 0;

	public Paddle player;
	public AIPaddle computer;


	public double timer =0;
	public double timerMax =1;

	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x + .08f * xdirection, 0, this.transform.position.z + zdirection * .08f * Random.Range (1, 5));

		player.transform.position = new Vector3 (-4,0,this.transform.position.z);

		timer += Time.deltaTime;
		Debug.Log (timer.ToString ());
		//if(timer >= timerMax){
			
			timer = 0;
			if (computer.transform.position.z -.05f  <= this.transform.position.z ) {
				computer.transform.position = new Vector3 (4,0,computer.transform.position.z +.2f);
			} 
			if (computer.transform.position.z +.05f  > this.transform.position.z ) {
				computer.transform.position = new Vector3 (4,0,computer.transform.position.z -.2f);
			}
		//}

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
