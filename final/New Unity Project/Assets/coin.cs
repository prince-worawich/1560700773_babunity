using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coin : MonoBehaviour {
	public Text bull;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		bullet ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "coin") {
			Destroy (this.gameObject);
			score++;
			bullet ();
		}
	}
	void bullet(){
		bull.text = "Score:" + score.ToString ();

	}
}
