using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private Transform Player;

	// Use this for initializations
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 novaPosiçao = new Vector3 (Player.position.x, Player.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, novaPosiçao, Time.time);
		
	}
}
