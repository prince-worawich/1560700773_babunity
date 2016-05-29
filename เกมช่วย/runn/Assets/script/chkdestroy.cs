using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class chkdestroy : MonoBehaviour {

	public Text scoreText;
	private int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c){
		if (c.gameObject.tag == "wall") {
			score += 1;
			scoreText.text = score.ToString ();
		}

	}
	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "wall") {
			Destroy(gameObject);
		}
	}
}
