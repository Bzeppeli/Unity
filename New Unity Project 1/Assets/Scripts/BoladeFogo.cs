using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoladeFogo : MonoBehaviour {

	private Rigidbody2D boladeFogo;
	public int impulso;
	private float posiçãoY = 0f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2f);
		boladeFogo.AddForce (new Vector2(0, posiçãoY * impulso));
		posiçãoY = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {

		if (posiçãoY > transform.position.y) {
			transform.eulerAngles = new Vector2 (180, 0);
		}

		posiçãoY = transform.position.y;

	}
}
