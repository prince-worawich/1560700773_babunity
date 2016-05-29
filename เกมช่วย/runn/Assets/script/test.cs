using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
 void update() {

	}
	public void Playagain(){
		Application.LoadLevel (0);
	}
	public void Play(){
		Application.LoadLevel (1);
	}

}