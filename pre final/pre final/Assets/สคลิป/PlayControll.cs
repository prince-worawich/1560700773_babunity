using UnityEngine;
using System.Collections;

public class PlayControll : MonoBehaviour {
	private Rigidbody rb;
	public float speed;



	void Start () {
		rb = GetComponent<Rigidbody> ();

	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce (movement*speed);
	
	}

	void OnTriggerEnter(Collider ghost)
	{
		if(ghost.gameObject.CompareTag("item"))
		{
			ghost.gameObject.SetActive (false);
		}
		}
}