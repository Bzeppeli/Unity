using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cogumelo : MonoBehaviour {

	public float ForçaPulo = 500f;
	public Rigidbody2D PlayerPulo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnCollisionEnter2D (Collision2D colisor){
		colisor.gameObject.PlayerPulo.AddForce (Vector2 (0, ForçaPulo));
	}

}
