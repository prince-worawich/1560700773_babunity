using UnityEngine;
using System.Collections;

public class random : MonoBehaviour 
{
	
	public float delay;
	public Transform bot;
	public float minY;
	public float maxY;
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", 1, delay);
	}
	
	void Update(){

	}

	void Spawn()
	{
		Vector3 position = bot.position;
		position.y = Random.Range (minY, maxY);

		GameObject.Instantiate (bot, position, Quaternion.identity);
	}
}

