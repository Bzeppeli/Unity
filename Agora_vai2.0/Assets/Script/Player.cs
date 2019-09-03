using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float pulo;
	public Rigidbody2D player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movimentação ();
	}

	void Movimentação(){
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}

		if (Input.GetButtonDown("Jump")){
			player.AddForce(new Vector2(0,pulo));
		}

	}
}
