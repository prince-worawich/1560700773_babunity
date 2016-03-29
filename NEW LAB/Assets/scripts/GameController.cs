using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject hazard;
	public int hazardCount;
	public float spawnWaite;
	public float waveWaite;
	public float startWaite;
	public Vector3 spawnValues;	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWaves());

	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWaite);


		while(true)
		{

		for(int i =0;i<hazardCount;i++)
		{
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x,11),spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);

			yield return new WaitForSeconds(spawnWaite);
	}
			yield return new WaitForSeconds(waveWaite);
}
}
}
