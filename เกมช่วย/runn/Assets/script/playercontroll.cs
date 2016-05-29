using UnityEngine;
using System.Collections;

public class playercontroll : MonoBehaviour 
{
	public Vector2 velocity;
	private Rigidbody rb;
	private int chkJump = 0;
	public float Jump;


	void Start() {
		//rb = GetComponent<Rigidbody2D>();

	}
//	void FixedUpdate() {
//
//		if (Input.GetButtonDown("Jump"))
//			rb.velocity = new Vector3(0, 7, 0);
//
//	}
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)&& chkJump > 0) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, Jump);

			chkJump--;
		}
	

		//if (keyDown || mouseDown) {
			//rigidbody2D.velocity = velocity;
		//}
	}
	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "floor") {
			chkJump = 2;
		}
	}
	void OnCollisionExit2D(Collision2D b){
		if (b.gameObject.tag == "floor") {
			//chkJump = false;
		}
	}


}

			
	


