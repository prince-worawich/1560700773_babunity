using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	float speedX =0;
	float speedY = -1;
	float speedZ =0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(new Vector3(speedX,speedY,speedZ)*Time.deltaTime);
	
	}
}
