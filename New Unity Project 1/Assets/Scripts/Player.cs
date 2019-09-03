using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float velocidade;
	public float forcaPulo;
	public Rigidbody2D playerRigidbody;
	private bool estaNoChao;
	public Transform chaoVerificador;
	public Transform spritePlayer;
	public Animator animator;
	// Use this for initialization
	void Start () {
		animator = spritePlayer.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		Movimentacao ();
		
	}

	void Movimentacao(){

		//animação
		animator.SetFloat ("Movimentação", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));
		//verificador de pulo
		estaNoChao = Physics2D.Linecast (transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer ("Piso"));
		animator.SetBool ("chao", estaNoChao);

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}

		if (Input.GetButtonDown ("Jump") && estaNoChao) {

			//Debug.Log ("pulo");
			playerRigidbody.AddForce (new Vector2 (0,forcaPulo));

		}


	}
}
