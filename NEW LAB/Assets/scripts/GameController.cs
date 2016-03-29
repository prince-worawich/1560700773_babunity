using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject hazard;
	public int hazardCount;
	public float spawnWaite;
	public float waveWaite;
	public float startWaite;
	public Vector3 spawnValues;


	public Text gameOverText;
	public Text restartText;
	public Text Scoretext;

	private int score;  

	private bool gameOver;
	private bool restart;

	void Start () {
		gameOver = false;
		restart = false;

		gameOverText.text = "";
		restartText.text = "";

		score = 0;
		UpdateScore ();

		StartCoroutine(SpawnWaves());




	}

	public void AddScore(int newScoreValus){
		score += newScoreValus;
		UpdateScore ();
	}
	void UpdateScore()
	{
		Scoretext.text = "Score:" + score.ToString();
	}

	public void GameOver()
	{
		gameOverText.text = "Game Over";
		gameOver = true;
	}

	void Update()
	{
		
			if (gameOver)
			{
				restart = true;
				restartText.text = "Press 'R' for Restart !";
			}

			if (restart)
			{
				if (Input.GetKeyDown (KeyCode.R)) 
				{
					Application.LoadLevel (Application.loadedLevel);
				}
			}
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
