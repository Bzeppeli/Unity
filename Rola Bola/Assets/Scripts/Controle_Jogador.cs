using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_jogador : MonoBehaviour {
	public float Speed;
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movimento = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movimento * Speed);
	}
}
