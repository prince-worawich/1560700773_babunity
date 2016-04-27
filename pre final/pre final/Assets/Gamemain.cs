using UnityEngine;
using System.Collections;
using UnityEditor.UI;

public class Gamemain : MonoBehaviour {
	public GameObject PlayerDeadPrefab;
	public Rigidbody rb;
	public GameObject Button1;
	public GameObject Button2;

	private int count1;
	private int count2;
	public Text countText;
	public Text countLife;

	// Use this for initialization
	void Start () {
		Button1.SetActive (false);
		rb = GetComponent<Rigidbody> ();
		count1 = 1;
		count2 = 0;
		countText.text = "Score: " + count2.ToString ();
		countLife.text = "Life: " + count1.ToString ();



	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag=="enemy"){
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
			count1=count-1;
			countLife.text="Life:"+count.ToString();
			Button1.SetActive(true);
			Button2.SetActive(true);

}
		else if (collision.gameObject.tag ==("point")){
			count2= count2 + 100;
			countText.text="Score : " +count2.ToString();
		}
}