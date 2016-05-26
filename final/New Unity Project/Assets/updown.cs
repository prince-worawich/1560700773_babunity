using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class updown : MonoBehaviour
{
	public Quaternion rotation = Quaternion.identity;
	public int countbuttondown = 0;
	public int countbutonup = 0;
	public Button btnclickup;
	public Button btnclickdown; 

	void Start ()
	{

	}
		
	void Update ()
	{

	}
	public void OnClickDown()
	{
		if (countbuttondown < 6)
		{
			transform.Rotate (new Vector3 (1, 0, 0), 5);
			btnclickup.enabled = true; 
			countbuttondown++;
			countbutonup--;
		} 
		if(countbuttondown > 6)
		{
			btnclickdown.enabled = false;  	
		}
	}
	public void OnClickUp()
	{
		if (countbutonup < 6)
		{
			transform.Rotate (new Vector3 (-1, 0, 0), 5);
			btnclickup.enabled = true; 
			countbutonup++;
			countbuttondown--;
		} 
		if(countbutonup > 6)
		{
			btnclickdown.enabled = false; 
		}
	}
}
