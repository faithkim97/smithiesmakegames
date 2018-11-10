using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public int speed;
	private Rigidbody2D rb;
	public int jumpPower;
	// Use this for initialization
	void Start () {
		// speed = 10;
		rb = gameObject.GetComponent<Rigidbody2D>();
		// jumpPower = 5000;
	}

	// Update is called once per frame
	void Update () {
		movePlayer();
	}


	private void movePlayer() {
		if (Input.GetKey(KeyCode.RightArrow)) {
			//move to the rigth
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			//jump
			rb.AddForce(Vector2.up * jumpPower);
		}

	}


	private void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.CompareTag("obstacle")) {
			collider.gameObject.SetActive(false);
		}
	}




}
