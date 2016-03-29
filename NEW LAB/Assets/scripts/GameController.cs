using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject hazard;

	// Use this for initialization
	void Start () {
		SpawnWaves();

	}

	void SpawnWaves(){
		Vector3 spawnPosition = new Vector3 (0.0f, 0.0f, 5f);
		Quaternion spawnRotation = Quaternion.identity;

		Instantiate (hazard, spawnPosition, spawnRotation);


	}
}
