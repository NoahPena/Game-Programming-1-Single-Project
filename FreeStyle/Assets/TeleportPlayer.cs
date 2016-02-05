using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			Debug.Log ("Pressed");

			GameObject.Find ("Player").transform.position = new Vector3 (35, 100, 5);

		}
	}
}
