using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour {

	private Transform player;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

			void onTringgerEnter2D (Collider2D colisor){
				if (colisor.gameObject.tag == "Player") {
				player.position = new Vector3 (0, 0, 0);

		}	
	}
}
