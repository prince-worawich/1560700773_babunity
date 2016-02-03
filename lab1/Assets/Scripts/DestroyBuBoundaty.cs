using UnityEngine;
using System.Collections;

public class DestroyBuBoundaty : MonoBehaviour {

	// Use this for initialization
	void OnTriggerExit(Collider other)
	{
		DestroyObject(other.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
