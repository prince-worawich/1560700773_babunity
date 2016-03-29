using UnityEngine;
using System.Collections;

public class RandomRatator : MonoBehaviour {
	public float tumble;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble;
	}
	

}
