using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "enemy") {
			Destroy (this.gameObject);
		}
	}
}
