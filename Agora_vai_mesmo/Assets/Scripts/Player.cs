using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float pulo;
	public float velocidade;
	public Rigidbody2D player;
	private bool estaNochao;
	public Transform chaoVerificador;
	public Transform spritePlayer;
	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = spritePlayer.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		movimentação ();
	}

	public void movimentação(){

		animator.SetFloat ("movimentação", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));

		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}

		if (Input.GetButtonDown ("Jump") && estaNochao) {
			player.AddForce( new Vector2(0, pulo));
		}

		estaNochao = Physics2D.Linecast (transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer ("Piso"));
	}
}
