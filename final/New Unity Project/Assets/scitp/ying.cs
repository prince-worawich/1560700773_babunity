using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ying : MonoBehaviour {
	public Rigidbody projectile;
	public Transform shots;
	public int shotw;
	public int speed;
	public Button Button;
	public Button Buttons;
	public Text Game;
	public int ball;
	public Text bull;
	//bool canjump;
	//int jumpcount=0;
	void Start()
	{
		ball = 3;
		bullet ();
		Button.gameObject.SetActive (false);
		Buttons.gameObject.SetActive (false);
		Game.gameObject.SetActive (false);
	}
	void Update()
	{
	}
	public void Shooting()
	{
		if(ball==0){
			Button.gameObject.SetActive (true);
			Buttons.gameObject.SetActive (true);
			Game.gameObject.SetActive (true);
		}
	
			Rigidbody shot = Instantiate (projectile, shots.position, shots.rotation) as Rigidbody;
			shot.velocity = new Vector3 (1, 1, 0) * shotw;
			//jumpcount++;
			ball--;
			bullet ();

	}
	void bullet(){
		bull.text = "Bullet:" + ball.ToString ();

	}

}
