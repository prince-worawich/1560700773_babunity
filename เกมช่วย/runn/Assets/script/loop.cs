using UnityEngine;
using System.Collections;

public class loop : MonoBehaviour 
{
	public float speed;
	public float left;
	public float offset;


	void Update () 
	{
		Vector2 position = transform.position;
		if (position.x < left)
			transform.Translate (offset, 0, 0);
		transform.Translate (-speed * Time.deltaTime, 0, 0);
	
	}
}
