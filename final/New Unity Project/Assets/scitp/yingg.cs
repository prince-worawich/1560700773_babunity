using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class yingg : MonoBehaviour {
	public float speed;
	public float tilt;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	private int count;
	private int count1;
	public Text countBullet;
	public Text countScore;
	// Use this for initialization
	void Start () {
		count = 1;
		count1 = 10;
		countBullet.text = "Bullet : " +count1.ToString ();
		countScore.text = "Score : " +count.ToString ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			count1 = count1 - 1;
			countBullet.text = "Bullet : " + count1.ToString ();
		}
	}
}
