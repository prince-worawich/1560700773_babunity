using UnityEngine;
using System.Collections;

public class Kadod : MonoBehaviour {
	public Rigidbody rb;
	public GameObject claw;
	public bool isShooting;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, 5, 0);
		
	}
	void Update(){
		if (rb.velocity.y < 0) {
			lastVelocity = rb.velocity.y;
		}
	}
	float lastVelocity;
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "floor") {
			//			float currentvelocity = rb.velocity.y;
			Debug.LogFormat ("currentvelocity = {0}", lastVelocity);
			rb.velocity = new Vector3 (0, -lastVelocity, 0);
			
		} else if (collision.gameObject.tag == "pedan") {
			Destroy (this.gameObject);
			Instantiate(
		}
	}
	
	
}