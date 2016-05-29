using UnityEngine;
using System.Collections;

public class playercontroll : MonoBehaviour 
{
	public Vector2 velocity;
	private Rigidbody rb;



	void Start() {
		rb = GetComponent<Rigidbody>();

	}
	void FixedUpdate() {

		if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, 7, 0);

	}
	void Update ()
	{
		bool keyDown = Input.GetKeyDown (KeyCode.Space);
		bool mouseDown = Input.GetMouseButtonDown (0);
	

		//if (keyDown || mouseDown) {
			//rigidbody2D.velocity = velocity;
		//}
	}


}

			
	


