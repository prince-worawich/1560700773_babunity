using UnityEngine;
using System.Collections;

public class randomtran : MonoBehaviour 
{

	public float speed;
	public float left;


		void Update () 
		{
			Vector3 position = transform.position;
			if (position.x < left)
			{
				Destroy (gameObject);
				return;
			}
			transform.Translate (-speed * Time.deltaTime, 0, 0);
		}

	
	
}

